namespace WinFormsApp1
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView5 = new DataGridView();
            button9 = new Button();
            label15 = new Label();
            label16 = new Label();
            textBoxFiltOrderSum = new TextBox();
            dateTimePickerFiltOrder = new DateTimePicker();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).BeginInit();
            SuspendLayout();
            // 
            // dataGridView5
            // 
            dataGridView5.AllowUserToAddRows = false;
            dataGridView5.AllowUserToDeleteRows = false;
            dataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView5.Location = new Point(12, 12);
            dataGridView5.Name = "dataGridView5";
            dataGridView5.Size = new Size(321, 391);
            dataGridView5.TabIndex = 8;
            // 
            // button9
            // 
            button9.Location = new Point(362, 93);
            button9.Name = "button9";
            button9.Size = new Size(118, 26);
            button9.TabIndex = 47;
            button9.Text = "фильтровать";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(620, 24);
            label15.Name = "label15";
            label15.Size = new Size(114, 15);
            label15.TabIndex = 46;
            label15.Text = "Стоимость больше";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(384, 24);
            label16.Name = "label16";
            label16.Size = new Size(116, 15);
            label16.TabIndex = 45;
            label16.Text = "Фильтр по времени";
            // 
            // textBoxFiltOrderSum
            // 
            textBoxFiltOrderSum.Location = new Point(620, 53);
            textBoxFiltOrderSum.Name = "textBoxFiltOrderSum";
            textBoxFiltOrderSum.Size = new Size(143, 23);
            textBoxFiltOrderSum.TabIndex = 44;
            // 
            // dateTimePickerFiltOrder
            // 
            dateTimePickerFiltOrder.Location = new Point(362, 53);
            dateTimePickerFiltOrder.Name = "dateTimePickerFiltOrder";
            dateTimePickerFiltOrder.Size = new Size(200, 23);
            dateTimePickerFiltOrder.TabIndex = 48;
            // 
            // button2
            // 
            button2.Location = new Point(713, 415);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 50;
            button2.Text = "Ок";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(dateTimePickerFiltOrder);
            Controls.Add(button9);
            Controls.Add(label15);
            Controls.Add(label16);
            Controls.Add(textBoxFiltOrderSum);
            Controls.Add(dataGridView5);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Фильтрация заказов";
            ((System.ComponentModel.ISupportInitialize)dataGridView5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView5;
        private Button button9;
        private Label label15;
        private Label label16;
        private TextBox textBoxFiltOrderSum;
        private DateTimePicker dateTimePickerFiltOrder;
        private Button button2;
    }
}