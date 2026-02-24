namespace WinFormsApp1
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            buttonDeleteIngr = new Button();
            label2 = new Label();
            label1 = new Label();
            TextCostIngred = new TextBox();
            textNameIngr = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            tabPage2 = new TabPage();
            buttonDeleteMain = new Button();
            label3 = new Label();
            label4 = new Label();
            TextCostMain = new TextBox();
            textNameMain = new TextBox();
            button2 = new Button();
            dataGridView2 = new DataGridView();
            tabPage3 = new TabPage();
            buttonDeleteBorders = new Button();
            temp = new Label();
            buttonEditBorders = new Button();
            checkedListBoxPizza = new CheckedListBox();
            label5 = new Label();
            label6 = new Label();
            textCostBorder = new TextBox();
            textNameBorder = new TextBox();
            button3 = new Button();
            dataGridView3 = new DataGridView();
            tabPage4 = new TabPage();
            buttonSaveChanges = new Button();
            buttonDeletePizza = new Button();
            comboBoxPizzaMain = new ComboBox();
            checkedListBoxIngredients = new CheckedListBox();
            checkedListBoxBorder = new CheckedListBox();
            buttonEditPizza = new Button();
            checkedListBoxBordersList = new CheckedListBox();
            label8 = new Label();
            textBoxNamePizza = new TextBox();
            button6 = new Button();
            dataGridView4 = new DataGridView();
            tabPage5 = new TabPage();
            checkBoxIsCombo = new CheckBox();
            label7 = new Label();
            buttonForAddInOrder = new Button();
            checkedListBoxForPizzaInOrder = new CheckedListBox();
            numericUpDownForCountPizza = new NumericUpDown();
            checkBoxForDouble = new CheckBox();
            comboBoxForSizePizza = new ComboBox();
            button4 = new Button();
            dataGridView6 = new DataGridView();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            dataGridView5 = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownForCountPizza).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Location = new Point(-8, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(838, 591);
            tabControl1.TabIndex = 20;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            tabControl1.Selecting += tabControl1_Selecting;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(buttonDeleteIngr);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(TextCostIngred);
            tabPage1.Controls.Add(textNameIngr);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(830, 563);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Ингредиенты";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteIngr
            // 
            buttonDeleteIngr.Location = new Point(431, 279);
            buttonDeleteIngr.Name = "buttonDeleteIngr";
            buttonDeleteIngr.Size = new Size(118, 26);
            buttonDeleteIngr.TabIndex = 22;
            buttonDeleteIngr.Text = "Удалить";
            buttonDeleteIngr.UseVisualStyleBackColor = true;
            buttonDeleteIngr.Click += buttonDeleteIngr_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(640, 184);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 5;
            label2.Text = "Стоимость";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(431, 190);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 4;
            label1.Text = "Название";
            // 
            // TextCostIngred
            // 
            TextCostIngred.Location = new Point(589, 218);
            TextCostIngred.Name = "TextCostIngred";
            TextCostIngred.Size = new Size(143, 23);
            TextCostIngred.TabIndex = 3;
            // 
            // textNameIngr
            // 
            textNameIngr.Location = new Point(431, 218);
            textNameIngr.Name = "textNameIngr";
            textNameIngr.Size = new Size(143, 23);
            textNameIngr.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(431, 247);
            button1.Name = "button1";
            button1.Size = new Size(118, 26);
            button1.TabIndex = 1;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(16, 21);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(356, 511);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellValidating += dataGridView1_CellValidating;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(buttonDeleteMain);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(TextCostMain);
            tabPage2.Controls.Add(textNameMain);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(830, 563);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Тесто";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteMain
            // 
            buttonDeleteMain.Location = new Point(461, 284);
            buttonDeleteMain.Name = "buttonDeleteMain";
            buttonDeleteMain.Size = new Size(118, 26);
            buttonDeleteMain.TabIndex = 23;
            buttonDeleteMain.Text = "Удалить";
            buttonDeleteMain.UseVisualStyleBackColor = true;
            buttonDeleteMain.Click += buttonDeleteMain_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(670, 189);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 11;
            label3.Text = "Стоимость";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(461, 195);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 10;
            label4.Text = "Название";
            // 
            // TextCostMain
            // 
            TextCostMain.Location = new Point(619, 223);
            TextCostMain.Name = "TextCostMain";
            TextCostMain.Size = new Size(143, 23);
            TextCostMain.TabIndex = 9;
            // 
            // textNameMain
            // 
            textNameMain.Location = new Point(461, 223);
            textNameMain.Name = "textNameMain";
            textNameMain.Size = new Size(143, 23);
            textNameMain.TabIndex = 8;
            // 
            // button2
            // 
            button2.Location = new Point(461, 252);
            button2.Name = "button2";
            button2.Size = new Size(118, 26);
            button2.TabIndex = 7;
            button2.Text = "Добавить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(29, 20);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(356, 511);
            dataGridView2.TabIndex = 6;
            dataGridView2.CellValidating += dataGridView2_CellValidating;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(buttonDeleteBorders);
            tabPage3.Controls.Add(temp);
            tabPage3.Controls.Add(buttonEditBorders);
            tabPage3.Controls.Add(checkedListBoxPizza);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(textCostBorder);
            tabPage3.Controls.Add(textNameBorder);
            tabPage3.Controls.Add(button3);
            tabPage3.Controls.Add(dataGridView3);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(830, 563);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Бортики";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteBorders
            // 
            buttonDeleteBorders.Location = new Point(459, 264);
            buttonDeleteBorders.Name = "buttonDeleteBorders";
            buttonDeleteBorders.Size = new Size(118, 26);
            buttonDeleteBorders.TabIndex = 24;
            buttonDeleteBorders.Text = "Удалить";
            buttonDeleteBorders.UseVisualStyleBackColor = true;
            buttonDeleteBorders.Click += buttonDeleteBorders_Click;
            // 
            // temp
            // 
            temp.AutoSize = true;
            temp.Location = new Point(736, 18);
            temp.Name = "temp";
            temp.Size = new Size(38, 15);
            temp.TabIndex = 12;
            temp.Text = "label7";
            // 
            // buttonEditBorders
            // 
            buttonEditBorders.Location = new Point(646, 487);
            buttonEditBorders.Name = "buttonEditBorders";
            buttonEditBorders.Size = new Size(143, 42);
            buttonEditBorders.TabIndex = 13;
            buttonEditBorders.Text = "Изменить совместимые пиццы";
            buttonEditBorders.UseVisualStyleBackColor = true;
            buttonEditBorders.Click += buttonEditBorders_Click;
            // 
            // checkedListBoxPizza
            // 
            checkedListBoxPizza.FormattingEnabled = true;
            checkedListBoxPizza.Location = new Point(646, 296);
            checkedListBoxPizza.Name = "checkedListBoxPizza";
            checkedListBoxPizza.Size = new Size(137, 184);
            checkedListBoxPizza.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(668, 169);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 11;
            label5.Text = "Стоимость";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(459, 175);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 10;
            label6.Text = "Название";
            // 
            // textCostBorder
            // 
            textCostBorder.Location = new Point(617, 203);
            textCostBorder.Name = "textCostBorder";
            textCostBorder.Size = new Size(143, 23);
            textCostBorder.TabIndex = 9;
            // 
            // textNameBorder
            // 
            textNameBorder.Location = new Point(459, 203);
            textNameBorder.Name = "textNameBorder";
            textNameBorder.Size = new Size(143, 23);
            textNameBorder.TabIndex = 8;
            // 
            // button3
            // 
            button3.Location = new Point(459, 232);
            button3.Name = "button3";
            button3.Size = new Size(118, 26);
            button3.TabIndex = 7;
            button3.Text = "Добавить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AllowUserToDeleteRows = false;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(25, 18);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(356, 511);
            dataGridView3.TabIndex = 6;
            dataGridView3.CellValidating += dataGridView3_CellValidating;
            dataGridView3.SelectionChanged += dataGridView3_SelectionChanged;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(buttonSaveChanges);
            tabPage4.Controls.Add(buttonDeletePizza);
            tabPage4.Controls.Add(comboBoxPizzaMain);
            tabPage4.Controls.Add(checkedListBoxIngredients);
            tabPage4.Controls.Add(checkedListBoxBorder);
            tabPage4.Controls.Add(buttonEditPizza);
            tabPage4.Controls.Add(checkedListBoxBordersList);
            tabPage4.Controls.Add(label8);
            tabPage4.Controls.Add(textBoxNamePizza);
            tabPage4.Controls.Add(button6);
            tabPage4.Controls.Add(dataGridView4);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(830, 563);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Пицца";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // buttonSaveChanges
            // 
            buttonSaveChanges.Location = new Point(716, 295);
            buttonSaveChanges.Name = "buttonSaveChanges";
            buttonSaveChanges.Size = new Size(75, 23);
            buttonSaveChanges.TabIndex = 26;
            buttonSaveChanges.Text = "Сохранить";
            buttonSaveChanges.UseVisualStyleBackColor = true;
            buttonSaveChanges.Visible = false;
            buttonSaveChanges.Click += buttonSaveChanges_Click;
            // 
            // buttonDeletePizza
            // 
            buttonDeletePizza.Location = new Point(422, 295);
            buttonDeletePizza.Name = "buttonDeletePizza";
            buttonDeletePizza.Size = new Size(118, 26);
            buttonDeletePizza.TabIndex = 25;
            buttonDeletePizza.Text = "Удалить";
            buttonDeletePizza.UseVisualStyleBackColor = true;
            buttonDeletePizza.Click += buttonDeletePizza_Click;
            // 
            // comboBoxPizzaMain
            // 
            comboBoxPizzaMain.FormattingEnabled = true;
            comboBoxPizzaMain.Location = new Point(670, 202);
            comboBoxPizzaMain.Name = "comboBoxPizzaMain";
            comboBoxPizzaMain.Size = new Size(121, 23);
            comboBoxPizzaMain.TabIndex = 24;
            // 
            // checkedListBoxIngredients
            // 
            checkedListBoxIngredients.FormattingEnabled = true;
            checkedListBoxIngredients.Location = new Point(401, 353);
            checkedListBoxIngredients.Name = "checkedListBoxIngredients";
            checkedListBoxIngredients.Size = new Size(137, 184);
            checkedListBoxIngredients.TabIndex = 23;
            // 
            // checkedListBoxBorder
            // 
            checkedListBoxBorder.FormattingEnabled = true;
            checkedListBoxBorder.Location = new Point(544, 353);
            checkedListBoxBorder.Name = "checkedListBoxBorder";
            checkedListBoxBorder.Size = new Size(137, 184);
            checkedListBoxBorder.TabIndex = 22;
            checkedListBoxBorder.ItemCheck += checkedListBoxBorder_ItemCheck;
            // 
            // buttonEditPizza
            // 
            buttonEditPizza.Location = new Point(422, 263);
            buttonEditPizza.Name = "buttonEditPizza";
            buttonEditPizza.Size = new Size(118, 26);
            buttonEditPizza.TabIndex = 21;
            buttonEditPizza.Text = "Изменить";
            buttonEditPizza.UseVisualStyleBackColor = true;
            buttonEditPizza.Click += buttonEditPizza_Click;
            // 
            // checkedListBoxBordersList
            // 
            checkedListBoxBordersList.FormattingEnabled = true;
            checkedListBoxBordersList.Location = new Point(687, 353);
            checkedListBoxBordersList.Name = "checkedListBoxBordersList";
            checkedListBoxBordersList.Size = new Size(137, 184);
            checkedListBoxBordersList.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(417, 184);
            label8.Name = "label8";
            label8.Size = new Size(59, 15);
            label8.TabIndex = 18;
            label8.Text = "Название";
            // 
            // textBoxNamePizza
            // 
            textBoxNamePizza.Location = new Point(417, 202);
            textBoxNamePizza.Name = "textBoxNamePizza";
            textBoxNamePizza.Size = new Size(143, 23);
            textBoxNamePizza.TabIndex = 16;
            // 
            // button6
            // 
            button6.Location = new Point(422, 231);
            button6.Name = "button6";
            button6.Size = new Size(118, 26);
            button6.TabIndex = 15;
            button6.Text = "Добавить";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // dataGridView4
            // 
            dataGridView4.AllowUserToAddRows = false;
            dataGridView4.AllowUserToDeleteRows = false;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(21, 39);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.Size = new Size(356, 498);
            dataGridView4.TabIndex = 14;
            dataGridView4.SelectionChanged += dataGridView4_SelectionChanged;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(checkBoxIsCombo);
            tabPage5.Controls.Add(label7);
            tabPage5.Controls.Add(buttonForAddInOrder);
            tabPage5.Controls.Add(checkedListBoxForPizzaInOrder);
            tabPage5.Controls.Add(numericUpDownForCountPizza);
            tabPage5.Controls.Add(checkBoxForDouble);
            tabPage5.Controls.Add(comboBoxForSizePizza);
            tabPage5.Controls.Add(button4);
            tabPage5.Controls.Add(dataGridView6);
            tabPage5.Controls.Add(textBox1);
            tabPage5.Controls.Add(dateTimePicker1);
            tabPage5.Controls.Add(dataGridView5);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(830, 563);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Заказы";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // checkBoxIsCombo
            // 
            checkBoxIsCombo.AutoSize = true;
            checkBoxIsCombo.Location = new Point(658, 28);
            checkBoxIsCombo.Name = "checkBoxIsCombo";
            checkBoxIsCombo.Size = new Size(100, 19);
            checkBoxIsCombo.TabIndex = 18;
            checkBoxIsCombo.Text = "Комбо пицца";
            checkBoxIsCombo.UseVisualStyleBackColor = true;
            checkBoxIsCombo.CheckedChanged += checkBoxIsCombo_CheckedChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(698, 519);
            label7.Name = "label7";
            label7.Size = new Size(105, 15);
            label7.TabIndex = 17;
            label7.Text = "общая стоимость";
            // 
            // buttonForAddInOrder
            // 
            buttonForAddInOrder.Location = new Point(416, 216);
            buttonForAddInOrder.Name = "buttonForAddInOrder";
            buttonForAddInOrder.Size = new Size(75, 23);
            buttonForAddInOrder.TabIndex = 16;
            buttonForAddInOrder.Text = "button5";
            buttonForAddInOrder.UseVisualStyleBackColor = true;
            buttonForAddInOrder.Click += buttonForAddInOrder_Click;
            // 
            // checkedListBoxForPizzaInOrder
            // 
            checkedListBoxForPizzaInOrder.FormattingEnabled = true;
            checkedListBoxForPizzaInOrder.Location = new Point(667, 67);
            checkedListBoxForPizzaInOrder.Name = "checkedListBoxForPizzaInOrder";
            checkedListBoxForPizzaInOrder.Size = new Size(143, 184);
            checkedListBoxForPizzaInOrder.TabIndex = 15;
            checkedListBoxForPizzaInOrder.ItemCheck += checkedListBoxForPizzaInOrder_ItemCheck;
            checkedListBoxForPizzaInOrder.SelectedIndexChanged += checkedListBoxForPizzaInOrder_SelectedIndexChanged;
            // 
            // numericUpDownForCountPizza
            // 
            numericUpDownForCountPizza.Location = new Point(397, 67);
            numericUpDownForCountPizza.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numericUpDownForCountPizza.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownForCountPizza.Name = "numericUpDownForCountPizza";
            numericUpDownForCountPizza.Size = new Size(120, 23);
            numericUpDownForCountPizza.TabIndex = 14;
            numericUpDownForCountPizza.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // checkBoxForDouble
            // 
            checkBoxForDouble.AutoSize = true;
            checkBoxForDouble.Location = new Point(658, 3);
            checkBoxForDouble.Name = "checkBoxForDouble";
            checkBoxForDouble.Size = new Size(145, 19);
            checkBoxForDouble.TabIndex = 13;
            checkBoxForDouble.Text = "Удвоить ингредиенты";
            checkBoxForDouble.UseVisualStyleBackColor = true;
            // 
            // comboBoxForSizePizza
            // 
            comboBoxForSizePizza.FormattingEnabled = true;
            comboBoxForSizePizza.Location = new Point(396, 18);
            comboBoxForSizePizza.Name = "comboBoxForSizePizza";
            comboBoxForSizePizza.Size = new Size(121, 23);
            comboBoxForSizePizza.TabIndex = 12;
            // 
            // button4
            // 
            button4.Location = new Point(396, 511);
            button4.Name = "button4";
            button4.Size = new Size(95, 23);
            button4.TabIndex = 11;
            button4.Text = "Создать заказ";
            button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView6
            // 
            dataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView6.Location = new Point(378, 274);
            dataGridView6.Name = "dataGridView6";
            dataGridView6.Size = new Size(444, 150);
            dataGridView6.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(396, 482);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(426, 23);
            textBox1.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(396, 453);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // dataGridView5
            // 
            dataGridView5.AllowUserToAddRows = false;
            dataGridView5.AllowUserToDeleteRows = false;
            dataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView5.Location = new Point(16, 18);
            dataGridView5.Name = "dataGridView5";
            dataGridView5.Size = new Size(356, 511);
            dataGridView5.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 644);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownForCountPizza).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView6).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private Button button1;
        private DataGridView dataGridView1;
        private TextBox TextCostIngred;
        private TextBox textNameIngr;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox TextCostMain;
        private TextBox textNameMain;
        private Button button2;
        private DataGridView dataGridView2;
        private Label label5;
        private Label label6;
        private TextBox textCostBorder;
        private TextBox textNameBorder;
        private Button button3;
        private DataGridView dataGridView3;
        private Button buttonEditBorders;
        private CheckedListBox checkedListBoxPizza;
        private Label temp;
        private Button buttonEditPizza;
        private CheckedListBox checkedListBoxBordersList;
        private Label label8;
        private TextBox textBoxNamePizza;
        private Button button6;
        private DataGridView dataGridView4;
        private CheckedListBox checkedListBoxBorder;
        private CheckedListBox checkedListBoxIngredients;
        private ComboBox comboBoxPizzaMain;
        private Button buttonDeletePizza;
        private Button buttonDeleteIngr;
        private Button buttonDeleteMain;
        private Button buttonDeleteBorders;
        private Button buttonSaveChanges;
        private DataGridView dataGridView5;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private Button button4;
        private DataGridView dataGridView6;
        private Label label7;
        private Button buttonForAddInOrder;
        private CheckedListBox checkedListBoxForPizzaInOrder;
        private NumericUpDown numericUpDownForCountPizza;
        private CheckBox checkBoxForDouble;
        private ComboBox comboBoxForSizePizza;
        private CheckBox checkBoxIsCombo;
    }
}
