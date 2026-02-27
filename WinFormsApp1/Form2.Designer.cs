namespace WinFormsApp1
{
    partial class FormEditPizza
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
            button1 = new Button();
            button2 = new Button();
            textBoxNamePizzaModal = new TextBox();
            label8 = new Label();
            checkedListBoxIngredientsModal = new CheckedListBox();
            comboBoxPizzaMainModal = new ComboBox();
            checkedListBoxModalBorder = new CheckedListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(713, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Отменить";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(12, 415);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Создать";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBoxNamePizzaModal
            // 
            textBoxNamePizzaModal.Location = new Point(237, 144);
            textBoxNamePizzaModal.Name = "textBoxNamePizzaModal";
            textBoxNamePizzaModal.Size = new Size(143, 23);
            textBoxNamePizzaModal.TabIndex = 28;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(237, 126);
            label8.Name = "label8";
            label8.Size = new Size(59, 15);
            label8.TabIndex = 29;
            label8.Text = "Название";
            // 
            // checkedListBoxIngredientsModal
            // 
            checkedListBoxIngredientsModal.FormattingEnabled = true;
            checkedListBoxIngredientsModal.Location = new Point(243, 211);
            checkedListBoxIngredientsModal.Name = "checkedListBoxIngredientsModal";
            checkedListBoxIngredientsModal.Size = new Size(137, 184);
            checkedListBoxIngredientsModal.TabIndex = 33;
            // 
            // comboBoxPizzaMainModal
            // 
            comboBoxPizzaMainModal.FormattingEnabled = true;
            comboBoxPizzaMainModal.Location = new Point(404, 144);
            comboBoxPizzaMainModal.Name = "comboBoxPizzaMainModal";
            comboBoxPizzaMainModal.Size = new Size(121, 23);
            comboBoxPizzaMainModal.TabIndex = 34;
            // 
            // checkedListBoxModalBorder
            // 
            checkedListBoxModalBorder.FormattingEnabled = true;
            checkedListBoxModalBorder.Location = new Point(404, 211);
            checkedListBoxModalBorder.Name = "checkedListBoxModalBorder";
            checkedListBoxModalBorder.Size = new Size(137, 184);
            checkedListBoxModalBorder.TabIndex = 35;
            checkedListBoxModalBorder.ItemCheck += checkedListBoxModalBorder_ItemCheck;
            // 
            // FormEditPizza
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkedListBoxModalBorder);
            Controls.Add(comboBoxPizzaMainModal);
            Controls.Add(checkedListBoxIngredientsModal);
            Controls.Add(label8);
            Controls.Add(textBoxNamePizzaModal);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormEditPizza";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Пицца для заказа";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button;
        private TextBox textBoxNamePizzaModal;
        private Label label8;
        private CheckedListBox checkedListBoxBordersList;
        private CheckedListBox checkedListBoxBorder;
        private CheckedListBox checkedListBoxIngredientsModal;
        private ComboBox comboBoxPizzaMainModal;
        private Button buttonDeletePizza;
        private CheckedListBox checkedListBoxModalBorder;
    }
}