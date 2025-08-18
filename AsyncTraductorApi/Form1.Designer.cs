namespace AsyncTraductorApi
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rtb_input = new System.Windows.Forms.RichTextBox();
            this.rtb_output = new System.Windows.Forms.RichTextBox();
            this.cb_Source_Language = new System.Windows.Forms.ComboBox();
            this.cb_Target_Language = new System.Windows.Forms.ComboBox();
            this.lbl_From = new System.Windows.Forms.Label();
            this.lbl_To = new System.Windows.Forms.Label();
            this.btn_Translate = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Listen = new System.Windows.Forms.Button();
            this.btn_Copy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Translation = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rtb_input
            // 
            this.rtb_input.BackColor = System.Drawing.Color.White;
            this.rtb_input.Location = new System.Drawing.Point(56, 94);
            this.rtb_input.Name = "rtb_input";
            this.rtb_input.Size = new System.Drawing.Size(697, 113);
            this.rtb_input.TabIndex = 0;
            this.rtb_input.Text = "";
            // 
            // rtb_output
            // 
            this.rtb_output.BackColor = System.Drawing.Color.White;
            this.rtb_output.Location = new System.Drawing.Point(57, 307);
            this.rtb_output.Name = "rtb_output";
            this.rtb_output.Size = new System.Drawing.Size(697, 118);
            this.rtb_output.TabIndex = 1;
            this.rtb_output.Text = "";
            this.rtb_output.TextChanged += new System.EventHandler(this.rtb_output_TextChanged);
            // 
            // cb_Source_Language
            // 
            this.cb_Source_Language.BackColor = System.Drawing.Color.White;
            this.cb_Source_Language.FormattingEnabled = true;
            this.cb_Source_Language.Location = new System.Drawing.Point(56, 240);
            this.cb_Source_Language.Name = "cb_Source_Language";
            this.cb_Source_Language.Size = new System.Drawing.Size(205, 24);
            this.cb_Source_Language.TabIndex = 2;
            this.cb_Source_Language.SelectedIndexChanged += new System.EventHandler(this.cb_Source_Language_SelectedIndexChanged);
            // 
            // cb_Target_Language
            // 
            this.cb_Target_Language.BackColor = System.Drawing.Color.White;
            this.cb_Target_Language.FormattingEnabled = true;
            this.cb_Target_Language.Location = new System.Drawing.Point(297, 240);
            this.cb_Target_Language.Name = "cb_Target_Language";
            this.cb_Target_Language.Size = new System.Drawing.Size(200, 24);
            this.cb_Target_Language.TabIndex = 3;
            // 
            // lbl_From
            // 
            this.lbl_From.AutoSize = true;
            this.lbl_From.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_From.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_From.Location = new System.Drawing.Point(53, 214);
            this.lbl_From.Name = "lbl_From";
            this.lbl_From.Size = new System.Drawing.Size(53, 23);
            this.lbl_From.TabIndex = 4;
            this.lbl_From.Text = "From:";
            // 
            // lbl_To
            // 
            this.lbl_To.AutoSize = true;
            this.lbl_To.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_To.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_To.Location = new System.Drawing.Point(293, 217);
            this.lbl_To.Name = "lbl_To";
            this.lbl_To.Size = new System.Drawing.Size(33, 20);
            this.lbl_To.TabIndex = 5;
            this.lbl_To.Text = "To:";
            // 
            // btn_Translate
            // 
            this.btn_Translate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Translate.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Translate.ForeColor = System.Drawing.Color.White;
            this.btn_Translate.Location = new System.Drawing.Point(525, 230);
            this.btn_Translate.Name = "btn_Translate";
            this.btn_Translate.Size = new System.Drawing.Size(99, 37);
            this.btn_Translate.TabIndex = 6;
            this.btn_Translate.Text = "Traducir";
            this.btn_Translate.UseVisualStyleBackColor = false;
            this.btn_Translate.Click += new System.EventHandler(this.btn_Translate_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Clear.Font = new System.Drawing.Font("Nirmala UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.Color.White;
            this.btn_Clear.Location = new System.Drawing.Point(642, 230);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(99, 37);
            this.btn_Clear.TabIndex = 7;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Listen
            // 
            this.btn_Listen.BackColor = System.Drawing.Color.Green;
            this.btn_Listen.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Listen.ForeColor = System.Drawing.Color.Black;
            this.btn_Listen.Location = new System.Drawing.Point(57, 431);
            this.btn_Listen.Name = "btn_Listen";
            this.btn_Listen.Size = new System.Drawing.Size(99, 37);
            this.btn_Listen.TabIndex = 8;
            this.btn_Listen.Text = "Listen";
            this.btn_Listen.UseVisualStyleBackColor = false;
            // 
            // btn_Copy
            // 
            this.btn_Copy.BackColor = System.Drawing.Color.Orange;
            this.btn_Copy.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Copy.ForeColor = System.Drawing.Color.Black;
            this.btn_Copy.Location = new System.Drawing.Point(185, 431);
            this.btn_Copy.Name = "btn_Copy";
            this.btn_Copy.Size = new System.Drawing.Size(99, 37);
            this.btn_Copy.TabIndex = 9;
            this.btn_Copy.Text = "Copy";
            this.btn_Copy.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(53, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Enter text to Translate:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 31);
            this.label2.TabIndex = 11;
            this.label2.Text = "DeepL Translator:";
            // 
            // lbl_Translation
            // 
            this.lbl_Translation.AutoSize = true;
            this.lbl_Translation.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Translation.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_Translation.Location = new System.Drawing.Point(53, 281);
            this.lbl_Translation.Name = "lbl_Translation";
            this.lbl_Translation.Size = new System.Drawing.Size(97, 23);
            this.lbl_Translation.TabIndex = 12;
            this.lbl_Translation.Text = "Translation:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(55, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 36);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 539);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_Translation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Copy);
            this.Controls.Add(this.btn_Listen);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Translate);
            this.Controls.Add(this.lbl_To);
            this.Controls.Add(this.lbl_From);
            this.Controls.Add(this.cb_Target_Language);
            this.Controls.Add(this.cb_Source_Language);
            this.Controls.Add(this.rtb_output);
            this.Controls.Add(this.rtb_input);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "DeepL Translator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_input;
        private System.Windows.Forms.RichTextBox rtb_output;
        private System.Windows.Forms.ComboBox cb_Source_Language;
        private System.Windows.Forms.ComboBox cb_Target_Language;
        private System.Windows.Forms.Label lbl_From;
        private System.Windows.Forms.Label lbl_To;
        private System.Windows.Forms.Button btn_Translate;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Listen;
        private System.Windows.Forms.Button btn_Copy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Translation;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

