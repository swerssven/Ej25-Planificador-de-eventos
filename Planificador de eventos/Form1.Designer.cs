
namespace Planificador_de_eventos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab_Cumpleanyos = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt_costeCena = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ckb_cenaSaludable = new System.Windows.Forms.CheckBox();
            this.ckb_CenaLujo = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nUD_personasCenas = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_textoTarta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_costeCumple = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ckb_cumpleLujo = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nUD_personasCumpleaños = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tab_Cumpleanyos.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_personasCenas)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_personasCumpleaños)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_Cumpleanyos
            // 
            this.tab_Cumpleanyos.Controls.Add(this.tabPage1);
            this.tab_Cumpleanyos.Controls.Add(this.tabPage2);
            this.tab_Cumpleanyos.Dock = System.Windows.Forms.DockStyle.Top;
            this.tab_Cumpleanyos.Location = new System.Drawing.Point(0, 0);
            this.tab_Cumpleanyos.Name = "tab_Cumpleanyos";
            this.tab_Cumpleanyos.SelectedIndex = 0;
            this.tab_Cumpleanyos.Size = new System.Drawing.Size(246, 326);
            this.tab_Cumpleanyos.TabIndex = 1;
            this.tab_Cumpleanyos.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tab_Cumpleanyos_Selecting);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txt_costeCena);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.ckb_cenaSaludable);
            this.tabPage1.Controls.Add(this.ckb_CenaLujo);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.nUD_personasCenas);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(238, 298);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cenas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txt_costeCena
            // 
            this.txt_costeCena.Location = new System.Drawing.Point(83, 165);
            this.txt_costeCena.Name = "txt_costeCena";
            this.txt_costeCena.ReadOnly = true;
            this.txt_costeCena.Size = new System.Drawing.Size(100, 23);
            this.txt_costeCena.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(36, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Coste:";
            // 
            // ckb_cenaSaludable
            // 
            this.ckb_cenaSaludable.AutoSize = true;
            this.ckb_cenaSaludable.Location = new System.Drawing.Point(29, 110);
            this.ckb_cenaSaludable.Name = "ckb_cenaSaludable";
            this.ckb_cenaSaludable.Size = new System.Drawing.Size(118, 19);
            this.ckb_cenaSaludable.TabIndex = 3;
            this.ckb_cenaSaludable.Text = "Opción saludable";
            this.ckb_cenaSaludable.UseVisualStyleBackColor = true;
            this.ckb_cenaSaludable.CheckedChanged += new System.EventHandler(this.ckb_cenaSaludable_CheckedChanged);
            // 
            // ckb_CenaLujo
            // 
            this.ckb_CenaLujo.AutoSize = true;
            this.ckb_CenaLujo.Location = new System.Drawing.Point(29, 68);
            this.ckb_CenaLujo.Name = "ckb_CenaLujo";
            this.ckb_CenaLujo.Size = new System.Drawing.Size(125, 19);
            this.ckb_CenaLujo.TabIndex = 2;
            this.ckb_CenaLujo.Text = "Decoración de lujo";
            this.ckb_CenaLujo.UseVisualStyleBackColor = true;
            this.ckb_CenaLujo.CheckedChanged += new System.EventHandler(this.ckb_CenaLujo_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Número de personas:";
            // 
            // nUD_personasCenas
            // 
            this.nUD_personasCenas.Location = new System.Drawing.Point(145, 16);
            this.nUD_personasCenas.Name = "nUD_personasCenas";
            this.nUD_personasCenas.ReadOnly = true;
            this.nUD_personasCenas.Size = new System.Drawing.Size(56, 23);
            this.nUD_personasCenas.TabIndex = 0;
            this.nUD_personasCenas.ValueChanged += new System.EventHandler(this.nUD_personasCenas_ValueChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txt_textoTarta);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txt_costeCumple);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.ckb_cumpleLujo);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.nUD_personasCumpleaños);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(238, 298);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cumpleaños";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txt_textoTarta
            // 
            this.txt_textoTarta.Location = new System.Drawing.Point(19, 123);
            this.txt_textoTarta.Name = "txt_textoTarta";
            this.txt_textoTarta.Size = new System.Drawing.Size(182, 23);
            this.txt_textoTarta.TabIndex = 13;
            this.txt_textoTarta.TextChanged += new System.EventHandler(this.txt_textoTarta_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(19, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Texto de la tarta:";
            // 
            // txt_costeCumple
            // 
            this.txt_costeCumple.Location = new System.Drawing.Point(83, 165);
            this.txt_costeCumple.Name = "txt_costeCumple";
            this.txt_costeCumple.ReadOnly = true;
            this.txt_costeCumple.Size = new System.Drawing.Size(100, 23);
            this.txt_costeCumple.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(36, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Coste:";
            // 
            // ckb_cumpleLujo
            // 
            this.ckb_cumpleLujo.AutoSize = true;
            this.ckb_cumpleLujo.Location = new System.Drawing.Point(29, 68);
            this.ckb_cumpleLujo.Name = "ckb_cumpleLujo";
            this.ckb_cumpleLujo.Size = new System.Drawing.Size(125, 19);
            this.ckb_cumpleLujo.TabIndex = 8;
            this.ckb_cumpleLujo.Text = "Decoración de lujo";
            this.ckb_cumpleLujo.UseVisualStyleBackColor = true;
            this.ckb_cumpleLujo.CheckedChanged += new System.EventHandler(this.ckb_cumpleLujo_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Número de personas:";
            // 
            // nUD_personasCumpleaños
            // 
            this.nUD_personasCumpleaños.Location = new System.Drawing.Point(145, 16);
            this.nUD_personasCumpleaños.Name = "nUD_personasCumpleaños";
            this.nUD_personasCumpleaños.ReadOnly = true;
            this.nUD_personasCumpleaños.Size = new System.Drawing.Size(56, 23);
            this.nUD_personasCumpleaños.TabIndex = 6;
            this.nUD_personasCumpleaños.ValueChanged += new System.EventHandler(this.nUD_personasCumpleaños_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(188, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "€";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(188, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "€";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 258);
            this.Controls.Add(this.tab_Cumpleanyos);
            this.Name = "Form1";
            this.Text = "Planificador eventos";
            this.tab_Cumpleanyos.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_personasCenas)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_personasCumpleaños)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_Cumpleanyos;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txt_costeCena;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckb_cenaSaludable;
        private System.Windows.Forms.CheckBox ckb_CenaLujo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nUD_personasCenas;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txt_textoTarta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_costeCumple;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ckb_cumpleLujo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nUD_personasCumpleaños;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

