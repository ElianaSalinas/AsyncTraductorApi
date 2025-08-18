using DeepL;
using AsyncTraductorApi.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncTraductorApi.Services
{
    // Servicio encargado de realizar traducciones usando la API DeepL
    public class TranslationService
    {
        // Instancia interna del traductor DeepL
        private readonly Translator _translator;

        // Evento personalizado para notificar cuando una traducción se completa
        public event EventHandler<TranslationResult> TranslationCompleted;

        // Constructor que recibe la clave API y crea la instancia del traductor
        public TranslationService(string apiKey)
        {
            _translator = new Translator(apiKey);
        }

        // Método asíncrono que traduce un texto a varios idiomas simultáneamente
        public async Task<List<TranslationResult>> TranslateMultipleAsync(
            string text,
            string sourceLang,
            List<string> targetLangs,
            CancellationToken token)
        {
            // Cronómetro para medir el tiempo total del proceso
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            // Crear tareas para cada idioma destino, ejecutándolas en paralelo
            var tasks = targetLangs.Select(async lang =>
            {
                // Verificar si se solicitó cancelación y lanzar excepción si es así
                token.ThrowIfCancellationRequested();

                // Simulación de carga de procesamiento paralelo intensivo
                await Task.Run(() => HeavyTextProcessing(text), token);

                // Llamada asíncrona a la API para traducir el texto
                var translation = await _translator.TranslateTextAsync(text, sourceLang, lang);

                // Crear un objeto con el resultado de la traducción y metadatos
                var result = new TranslationResult
                {
                    OriginalText = text,
                    TranslatedText = translation.Text,
                    SourceLanguage = sourceLang,
                    TargetLanguage = lang,
                    ProcessingTimeSeconds = stopwatch.Elapsed.TotalSeconds
                };

                // Disparar evento notificando que la traducción para este idioma terminó
                TranslationCompleted?.Invoke(this, result);

                // Devolver resultado para agregarse a la lista final
                return result;

            }).ToList();

            // Esperar que todas las tareas de traducción terminen
            var results = await Task.WhenAll(tasks);

            stopwatch.Stop();

            // Retornar resultados en una lista
            return results.ToList();
        }

        // Método privado que simula una tarea pesada para demostrar concurrencia
        private void HeavyTextProcessing(string text)
        {
            // Ejecuta un ciclo paralelo que simula cálculo intensivo
            Parallel.For(0, 100000, i =>
            {
                var temp = text.Length * i;
            });
        }
    }
}

