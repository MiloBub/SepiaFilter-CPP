﻿using System;

namespace Sepia_JA
{
    partial class SepiaForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBefore = new System.Windows.Forms.PictureBox();
            this.pictureAfter = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CS = new System.Windows.Forms.RadioButton();
            this.ASM = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.threadsNumber = new System.Windows.Forms.TrackBar();
            this.loadButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.startButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.threads = new System.Windows.Forms.Label();
            this.ms = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBefore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAfter)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.threadsNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBefore
            // 
            this.pictureBefore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBefore.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBefore.Location = new System.Drawing.Point(32, 29);
            this.pictureBefore.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBefore.Name = "pictureBefore";
            this.pictureBefore.Size = new System.Drawing.Size(500, 350);
            this.pictureBefore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBefore.TabIndex = 11;
            this.pictureBefore.TabStop = false;
            // 
            // pictureAfter
            // 
            this.pictureAfter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureAfter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureAfter.Location = new System.Drawing.Point(652, 29);
            this.pictureAfter.Margin = new System.Windows.Forms.Padding(4);
            this.pictureAfter.Name = "pictureAfter";
            this.pictureAfter.Size = new System.Drawing.Size(500, 350);
            this.pictureAfter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureAfter.TabIndex = 12;
            this.pictureAfter.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CS);
            this.groupBox1.Controls.Add(this.ASM);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(32, 477);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 176);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "";
            this.groupBox1.Text = "Implementation";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // CS
            // 
            this.CS.AutoSize = true;
            this.CS.Location = new System.Drawing.Point(17, 122);
            this.CS.Name = "CS";
            this.CS.Size = new System.Drawing.Size(64, 26);
            this.CS.TabIndex = 16;
            this.CS.TabStop = true;
            this.CS.Text = "C++";
            this.CS.UseVisualStyleBackColor = true;
            this.CS.CheckedChanged += new System.EventHandler(this.CS_CheckedChanged);
            // 
            // ASM
            // 
            this.ASM.AutoSize = true;
            this.ASM.Location = new System.Drawing.Point(17, 55);
            this.ASM.Name = "ASM";
            this.ASM.Size = new System.Drawing.Size(69, 26);
            this.ASM.TabIndex = 15;
            this.ASM.TabStop = true;
            this.ASM.Text = "ASM";
            this.ASM.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.threadsNumber);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(32, 387);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1120, 84);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Number of threads";
            // 
            // threadsNumber
            // 
            this.threadsNumber.Location = new System.Drawing.Point(5, 24);
            this.threadsNumber.Margin = new System.Windows.Forms.Padding(2);
            this.threadsNumber.Maximum = 64;
            this.threadsNumber.Minimum = 1;
            this.threadsNumber.Name = "threadsNumber";
            this.threadsNumber.Size = new System.Drawing.Size(1109, 45);
            this.threadsNumber.TabIndex = 0;
            this.threadsNumber.Value = 4;
            this.threadsNumber.Scroll += new System.EventHandler(this.threads_Scroll);
            // 
            // loadButton
            // 
            this.loadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loadButton.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadButton.ForeColor = System.Drawing.Color.White;
            this.loadButton.Location = new System.Drawing.Point(244, 477);
            this.loadButton.Margin = new System.Windows.Forms.Padding(2);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(288, 81);
            this.loadButton.TabIndex = 15;
            this.loadButton.Text = "Load BMP";
            this.loadButton.UseVisualStyleBackColor = false;
            this.loadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.saveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.saveButton.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(244, 571);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(288, 81);
            this.saveButton.TabIndex = 16;
            this.saveButton.Text = "Save BMP";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(648, 477);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 22);
            this.label1.TabIndex = 17;
            this.label1.Text = "Number of threads:";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.Color.Black;
            this.time.Location = new System.Drawing.Point(828, 521);
            this.time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(25, 22);
            this.time.TabIndex = 18;
            this.time.Text = "...";
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.startButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.startButton.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.White;
            this.startButton.Location = new System.Drawing.Point(652, 571);
            this.startButton.Margin = new System.Windows.Forms.Padding(2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(288, 81);
            this.startButton.TabIndex = 20;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(648, 521);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 22);
            this.label2.TabIndex = 21;
            this.label2.Text = "Execution time:";
            // 
            // threads
            // 
            this.threads.AutoSize = true;
            this.threads.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threads.ForeColor = System.Drawing.Color.Black;
            this.threads.Location = new System.Drawing.Point(845, 477);
            this.threads.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.threads.Name = "threads";
            this.threads.Size = new System.Drawing.Size(21, 22);
            this.threads.TabIndex = 22;
            this.threads.Text = "4";
            // 
            // ms
            // 
            this.ms.AutoSize = true;
            this.ms.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ms.ForeColor = System.Drawing.Color.Black;
            this.ms.Location = new System.Drawing.Point(905, 521);
            this.ms.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ms.Name = "ms";
            this.ms.Size = new System.Drawing.Size(36, 22);
            this.ms.TabIndex = 23;
            this.ms.Text = "ms";
            // 
            // SepiaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1186, 680);
            this.Controls.Add(this.ms);
            this.Controls.Add(this.threads);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.time);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureAfter);
            this.Controls.Add(this.pictureBefore);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SepiaForm";
            this.Text = "Sepia";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBefore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAfter)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.threadsNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBefore;
        private System.Windows.Forms.PictureBox pictureAfter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton CS;
        private System.Windows.Forms.RadioButton ASM;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TrackBar threadsNumber;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label time;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label threads;
        private System.Windows.Forms.Label ms;
    }
}