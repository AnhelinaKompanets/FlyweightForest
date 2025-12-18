namespace FlyweightForest
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
            cbTypes = new ComboBox();
            lblTypes = new Label();
            nudCount = new NumericUpDown();
            lblCount = new Label();
            btnStart = new Button();
            lblAdd = new Label();
            label1 = new Label();
            btnClear = new Button();
            panelForest = new Panel();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)nudCount).BeginInit();
            SuspendLayout();
            // 
            // cbTypes
            // 
            cbTypes.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cbTypes.FormattingEnabled = true;
            cbTypes.Location = new Point(12, 41);
            cbTypes.Name = "cbTypes";
            cbTypes.Size = new Size(151, 27);
            cbTypes.TabIndex = 0;
            // 
            // lblTypes
            // 
            lblTypes.AutoSize = true;
            lblTypes.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblTypes.Location = new Point(12, 18);
            lblTypes.Name = "lblTypes";
            lblTypes.Size = new Size(139, 19);
            lblTypes.TabIndex = 1;
            lblTypes.Text = "Вибір виду дерева";
            // 
            // nudCount
            // 
            nudCount.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            nudCount.Location = new Point(13, 133);
            nudCount.Name = "nudCount";
            nudCount.Size = new Size(150, 27);
            nudCount.TabIndex = 2;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblCount.Location = new Point(13, 110);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(122, 19);
            lblCount.TabIndex = 3;
            lblCount.Text = "Кількість дерев";
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnStart.Location = new Point(12, 225);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(151, 29);
            btnStart.TabIndex = 4;
            btnStart.Text = "Старт/Стоп";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // lblAdd
            // 
            lblAdd.AutoSize = true;
            lblAdd.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblAdd.Location = new Point(13, 202);
            lblAdd.Name = "lblAdd";
            lblAdd.Size = new Size(114, 19);
            lblAdd.TabIndex = 5;
            lblAdd.Text = "Посадка дерев";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(19, 296);
            label1.Name = "label1";
            label1.Size = new Size(116, 19);
            label1.TabIndex = 6;
            label1.Text = "Очищення лісу";
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnClear.Location = new Point(13, 318);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(151, 29);
            btnClear.TabIndex = 7;
            btnClear.Text = "Очистити";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // panelForest
            // 
            panelForest.Location = new Point(193, 0);
            panelForest.Name = "panelForest";
            panelForest.Size = new Size(595, 452);
            panelForest.TabIndex = 8;
            panelForest.Paint += panelForest_Paint;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnAdd.Location = new Point(13, 400);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(151, 29);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Додати";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdd);
            Controls.Add(panelForest);
            Controls.Add(btnClear);
            Controls.Add(label1);
            Controls.Add(lblAdd);
            Controls.Add(btnStart);
            Controls.Add(lblCount);
            Controls.Add(nudCount);
            Controls.Add(lblTypes);
            Controls.Add(cbTypes);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nudCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbTypes;
        private Label lblTypes;
        private NumericUpDown nudCount;
        private Label lblCount;
        private Button btnStart;
        private Label lblAdd;
        private Label label1;
        private Button btnClear;
        private Panel panelForest;
        private Button btnAdd;
    }
}
