namespace ResponsiJunpro
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbNama = new TextBox();
            rbHR = new RadioButton();
            rbENG = new RadioButton();
            rbDEV = new RadioButton();
            rbPM = new RadioButton();
            rbFIN = new RadioButton();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            btnInsert = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            dgvData = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(89, 37);
            label1.TabIndex = 0;
            label1.Text = "LOGO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 74);
            label2.Name = "label2";
            label2.Size = new Size(124, 20);
            label2.TabIndex = 1;
            label2.Text = "Nama Karyawan :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 110);
            label3.Name = "label3";
            label3.Size = new Size(115, 20);
            label3.TabIndex = 2;
            label3.Text = "Dep. Karyawan :";
            // 
            // tbNama
            // 
            tbNama.Location = new Point(154, 75);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(290, 23);
            tbNama.TabIndex = 3;
            // 
            // rbHR
            // 
            rbHR.AutoSize = true;
            rbHR.Location = new Point(154, 112);
            rbHR.Name = "rbHR";
            rbHR.Size = new Size(41, 19);
            rbHR.TabIndex = 4;
            rbHR.TabStop = true;
            rbHR.Text = "HR";
            rbHR.UseVisualStyleBackColor = true;
            // 
            // rbENG
            // 
            rbENG.AutoSize = true;
            rbENG.Location = new Point(210, 112);
            rbENG.Name = "rbENG";
            rbENG.Size = new Size(48, 19);
            rbENG.TabIndex = 5;
            rbENG.TabStop = true;
            rbENG.Text = "ENG";
            rbENG.UseVisualStyleBackColor = true;
            // 
            // rbDEV
            // 
            rbDEV.AutoSize = true;
            rbDEV.Location = new Point(276, 112);
            rbDEV.Name = "rbDEV";
            rbDEV.Size = new Size(46, 19);
            rbDEV.TabIndex = 6;
            rbDEV.TabStop = true;
            rbDEV.Text = "DEV";
            rbDEV.UseVisualStyleBackColor = true;
            // 
            // rbPM
            // 
            rbPM.AutoSize = true;
            rbPM.Location = new Point(340, 112);
            rbPM.Name = "rbPM";
            rbPM.Size = new Size(43, 19);
            rbPM.TabIndex = 7;
            rbPM.TabStop = true;
            rbPM.Text = "PM";
            rbPM.UseVisualStyleBackColor = true;
            // 
            // rbFIN
            // 
            rbFIN.AutoSize = true;
            rbFIN.Location = new Point(401, 112);
            rbFIN.Name = "rbFIN";
            rbFIN.Size = new Size(43, 19);
            rbFIN.TabIndex = 8;
            rbFIN.TabStop = true;
            rbFIN.Text = "FIN";
            rbFIN.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(631, 12);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 9;
            label4.Text = "ID Departemen:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(631, 42);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 10;
            label5.Text = "HR : HR";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(631, 69);
            label6.Name = "label6";
            label6.Size = new Size(85, 15);
            label6.TabIndex = 11;
            label6.Text = "ENG : Engineer";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(631, 96);
            label7.Name = "label7";
            label7.Size = new Size(87, 15);
            label7.TabIndex = 12;
            label7.Text = "DEV: Developer";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(631, 123);
            label8.Name = "label8";
            label8.Size = new Size(123, 15);
            label8.TabIndex = 13;
            label8.Text = "PM: Product Manager";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(631, 147);
            label9.Name = "label9";
            label9.Size = new Size(72, 15);
            label9.TabIndex = 14;
            label9.Text = "FIN: Finance";
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(16, 158);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(115, 31);
            btnInsert.TabIndex = 15;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(158, 158);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(115, 31);
            btnEdit.TabIndex = 16;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(301, 158);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(115, 31);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(12, 226);
            dgvData.Name = "dgvData";
            dgvData.Size = new Size(776, 299);
            dgvData.TabIndex = 19;
            dgvData.CellClick += dgvData_CellClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 537);
            Controls.Add(dgvData);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnInsert);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(rbFIN);
            Controls.Add(rbPM);
            Controls.Add(rbDEV);
            Controls.Add(rbENG);
            Controls.Add(rbHR);
            Controls.Add(tbNama);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbNama;
        private RadioButton rbHR;
        private RadioButton rbENG;
        private RadioButton rbDEV;
        private RadioButton rbPM;
        private RadioButton rbFIN;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button btnInsert;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridView dgvData;
    }
}
