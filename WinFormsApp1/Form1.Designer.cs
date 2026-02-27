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
            button5 = new Button();
            label9 = new Label();
            label10 = new Label();
            textBoxPriceFilter = new TextBox();
            textBoxNameIngrFilter = new TextBox();
            buttonDeleteIngr = new Button();
            label2 = new Label();
            label1 = new Label();
            TextCostIngred = new TextBox();
            textNameIngr = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            tabPage2 = new TabPage();
            button7 = new Button();
            label11 = new Label();
            label12 = new Label();
            textBoxPizzaMainFilterPrice = new TextBox();
            textBoxPizzaMainFilterName = new TextBox();
            buttonDeleteMain = new Button();
            label3 = new Label();
            label4 = new Label();
            TextCostMain = new TextBox();
            textNameMain = new TextBox();
            button2 = new Button();
            dataGridView2 = new DataGridView();
            tabPage3 = new TabPage();
            label33 = new Label();
            label32 = new Label();
            checkedListBoxForBorderSort = new CheckedListBox();
            button8 = new Button();
            label13 = new Label();
            label14 = new Label();
            textBoxBordFiltPrice = new TextBox();
            textBoxBordFiltName = new TextBox();
            buttonDeleteBorders = new Button();
            buttonEditBorders = new Button();
            checkedListBoxPizza = new CheckedListBox();
            label5 = new Label();
            label6 = new Label();
            textCostBorder = new TextBox();
            textNameBorder = new TextBox();
            button3 = new Button();
            dataGridView3 = new DataGridView();
            tabPage4 = new TabPage();
            label31 = new Label();
            label30 = new Label();
            label29 = new Label();
            label28 = new Label();
            label27 = new Label();
            label26 = new Label();
            label25 = new Label();
            button9 = new Button();
            label15 = new Label();
            label16 = new Label();
            textBoxFiltPizza2 = new TextBox();
            textBoxFiltPizza1 = new TextBox();
            checkedListBoxFlitPizza1 = new CheckedListBox();
            checkedListBoxFlitPizza2 = new CheckedListBox();
            checkedListBoxFlitPizza3 = new CheckedListBox();
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
            label24 = new Label();
            label23 = new Label();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label7 = new Label();
            buttonOpenFilt = new Button();
            checkBox1 = new CheckBox();
            buttonOpenForm = new Button();
            comboBoxForPizzaMainInOrder = new ComboBox();
            comboBoxForPizzaA = new ComboBox();
            comboBoxForPizzaB = new ComboBox();
            checkedListBoxForPizzaInOrder2 = new CheckedListBox();
            buttonForAddInOrder = new Button();
            checkedListBoxForPizzaInOrder = new CheckedListBox();
            numericUpDownForCountPizza = new NumericUpDown();
            checkBoxForDouble = new CheckBox();
            comboBoxForSizePizza = new ComboBox();
            button4 = new Button();
            dataGridView6 = new DataGridView();
            textBoxComment = new TextBox();
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
            tabPage1.Controls.Add(button5);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(textBoxPriceFilter);
            tabPage1.Controls.Add(textBoxNameIngrFilter);
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
            // button5
            // 
            button5.Location = new Point(447, 129);
            button5.Name = "button5";
            button5.Size = new Size(118, 26);
            button5.TabIndex = 27;
            button5.Text = "фильтровать";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(605, 72);
            label9.Name = "label9";
            label9.Size = new Size(114, 15);
            label9.TabIndex = 26;
            label9.Text = "Стоимость больше";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(447, 72);
            label10.Name = "label10";
            label10.Size = new Size(122, 15);
            label10.TabIndex = 25;
            label10.Text = "Фильтр по названию";
            // 
            // textBoxPriceFilter
            // 
            textBoxPriceFilter.Location = new Point(605, 100);
            textBoxPriceFilter.Name = "textBoxPriceFilter";
            textBoxPriceFilter.Size = new Size(143, 23);
            textBoxPriceFilter.TabIndex = 24;
            // 
            // textBoxNameIngrFilter
            // 
            textBoxNameIngrFilter.Location = new Point(447, 100);
            textBoxNameIngrFilter.Name = "textBoxNameIngrFilter";
            textBoxNameIngrFilter.Size = new Size(143, 23);
            textBoxNameIngrFilter.TabIndex = 23;
            // 
            // buttonDeleteIngr
            // 
            buttonDeleteIngr.Location = new Point(447, 412);
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
            label2.Location = new Point(656, 317);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 5;
            label2.Text = "Стоимость";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(447, 323);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 4;
            label1.Text = "Название";
            // 
            // TextCostIngred
            // 
            TextCostIngred.Location = new Point(605, 351);
            TextCostIngred.Name = "TextCostIngred";
            TextCostIngred.Size = new Size(143, 23);
            TextCostIngred.TabIndex = 3;
            // 
            // textNameIngr
            // 
            textNameIngr.Location = new Point(447, 351);
            textNameIngr.Name = "textNameIngr";
            textNameIngr.Size = new Size(143, 23);
            textNameIngr.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(447, 380);
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
            tabPage2.Controls.Add(button7);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(textBoxPizzaMainFilterPrice);
            tabPage2.Controls.Add(textBoxPizzaMainFilterName);
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
            // button7
            // 
            button7.Location = new Point(462, 168);
            button7.Name = "button7";
            button7.Size = new Size(118, 26);
            button7.TabIndex = 32;
            button7.Text = "фильтровать";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(620, 111);
            label11.Name = "label11";
            label11.Size = new Size(114, 15);
            label11.TabIndex = 31;
            label11.Text = "Стоимость больше";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(462, 111);
            label12.Name = "label12";
            label12.Size = new Size(122, 15);
            label12.TabIndex = 30;
            label12.Text = "Фильтр по названию";
            // 
            // textBoxPizzaMainFilterPrice
            // 
            textBoxPizzaMainFilterPrice.Location = new Point(620, 139);
            textBoxPizzaMainFilterPrice.Name = "textBoxPizzaMainFilterPrice";
            textBoxPizzaMainFilterPrice.Size = new Size(143, 23);
            textBoxPizzaMainFilterPrice.TabIndex = 29;
            // 
            // textBoxPizzaMainFilterName
            // 
            textBoxPizzaMainFilterName.Location = new Point(462, 139);
            textBoxPizzaMainFilterName.Name = "textBoxPizzaMainFilterName";
            textBoxPizzaMainFilterName.Size = new Size(143, 23);
            textBoxPizzaMainFilterName.TabIndex = 28;
            // 
            // buttonDeleteMain
            // 
            buttonDeleteMain.Location = new Point(462, 341);
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
            label3.Location = new Point(671, 246);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 11;
            label3.Text = "Стоимость";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(462, 252);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 10;
            label4.Text = "Название";
            // 
            // TextCostMain
            // 
            TextCostMain.Location = new Point(620, 280);
            TextCostMain.Name = "TextCostMain";
            TextCostMain.Size = new Size(143, 23);
            TextCostMain.TabIndex = 9;
            // 
            // textNameMain
            // 
            textNameMain.Location = new Point(462, 280);
            textNameMain.Name = "textNameMain";
            textNameMain.Size = new Size(143, 23);
            textNameMain.TabIndex = 8;
            // 
            // button2
            // 
            button2.Location = new Point(462, 309);
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
            tabPage3.Controls.Add(label33);
            tabPage3.Controls.Add(label32);
            tabPage3.Controls.Add(checkedListBoxForBorderSort);
            tabPage3.Controls.Add(button8);
            tabPage3.Controls.Add(label13);
            tabPage3.Controls.Add(label14);
            tabPage3.Controls.Add(textBoxBordFiltPrice);
            tabPage3.Controls.Add(textBoxBordFiltName);
            tabPage3.Controls.Add(buttonDeleteBorders);
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
            // label33
            // 
            label33.AutoSize = true;
            label33.Location = new Point(684, 18);
            label33.Name = "label33";
            label33.Size = new Size(108, 15);
            label33.TabIndex = 40;
            label33.Text = "Доступные пиццы";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(693, 313);
            label32.Name = "label32";
            label32.Size = new Size(108, 15);
            label32.TabIndex = 39;
            label32.Text = "Доступные пиццы";
            // 
            // checkedListBoxForBorderSort
            // 
            checkedListBoxForBorderSort.FormattingEnabled = true;
            checkedListBoxForBorderSort.Location = new Point(684, 41);
            checkedListBoxForBorderSort.Name = "checkedListBoxForBorderSort";
            checkedListBoxForBorderSort.Size = new Size(137, 184);
            checkedListBoxForBorderSort.TabIndex = 38;
            // 
            // button8
            // 
            button8.Location = new Point(386, 120);
            button8.Name = "button8";
            button8.Size = new Size(118, 26);
            button8.TabIndex = 37;
            button8.Text = "фильтровать";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(535, 63);
            label13.Name = "label13";
            label13.Size = new Size(114, 15);
            label13.TabIndex = 36;
            label13.Text = "Стоимость больше";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(386, 63);
            label14.Name = "label14";
            label14.Size = new Size(122, 15);
            label14.TabIndex = 35;
            label14.Text = "Фильтр по названию";
            // 
            // textBoxBordFiltPrice
            // 
            textBoxBordFiltPrice.Location = new Point(535, 91);
            textBoxBordFiltPrice.Name = "textBoxBordFiltPrice";
            textBoxBordFiltPrice.Size = new Size(143, 23);
            textBoxBordFiltPrice.TabIndex = 34;
            // 
            // textBoxBordFiltName
            // 
            textBoxBordFiltName.Location = new Point(386, 91);
            textBoxBordFiltName.Name = "textBoxBordFiltName";
            textBoxBordFiltName.Size = new Size(143, 23);
            textBoxBordFiltName.TabIndex = 33;
            // 
            // buttonDeleteBorders
            // 
            buttonDeleteBorders.Location = new Point(395, 431);
            buttonDeleteBorders.Name = "buttonDeleteBorders";
            buttonDeleteBorders.Size = new Size(118, 26);
            buttonDeleteBorders.TabIndex = 24;
            buttonDeleteBorders.Text = "Удалить";
            buttonDeleteBorders.UseVisualStyleBackColor = true;
            buttonDeleteBorders.Click += buttonDeleteBorders_Click;
            // 
            // buttonEditBorders
            // 
            buttonEditBorders.Location = new Point(684, 521);
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
            checkedListBoxPizza.Location = new Point(693, 331);
            checkedListBoxPizza.Name = "checkedListBoxPizza";
            checkedListBoxPizza.Size = new Size(137, 184);
            checkedListBoxPizza.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(595, 336);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 11;
            label5.Text = "Стоимость";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(396, 338);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 10;
            label6.Text = "Название";
            // 
            // textCostBorder
            // 
            textCostBorder.Location = new Point(544, 370);
            textCostBorder.Name = "textCostBorder";
            textCostBorder.Size = new Size(143, 23);
            textCostBorder.TabIndex = 9;
            // 
            // textNameBorder
            // 
            textNameBorder.Location = new Point(395, 370);
            textNameBorder.Name = "textNameBorder";
            textNameBorder.Size = new Size(143, 23);
            textNameBorder.TabIndex = 8;
            // 
            // button3
            // 
            button3.Location = new Point(395, 399);
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
            tabPage4.Controls.Add(label31);
            tabPage4.Controls.Add(label30);
            tabPage4.Controls.Add(label29);
            tabPage4.Controls.Add(label28);
            tabPage4.Controls.Add(label27);
            tabPage4.Controls.Add(label26);
            tabPage4.Controls.Add(label25);
            tabPage4.Controls.Add(button9);
            tabPage4.Controls.Add(label15);
            tabPage4.Controls.Add(label16);
            tabPage4.Controls.Add(textBoxFiltPizza2);
            tabPage4.Controls.Add(textBoxFiltPizza1);
            tabPage4.Controls.Add(checkedListBoxFlitPizza1);
            tabPage4.Controls.Add(checkedListBoxFlitPizza2);
            tabPage4.Controls.Add(checkedListBoxFlitPizza3);
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
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(690, 74);
            label31.Name = "label31";
            label31.Size = new Size(46, 15);
            label31.TabIndex = 49;
            label31.Text = "Бортик";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(547, 74);
            label30.Name = "label30";
            label30.Size = new Size(38, 15);
            label30.TabIndex = 48;
            label30.Text = "Тесто";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(404, 74);
            label29.Name = "label29";
            label29.Size = new Size(81, 15);
            label29.TabIndex = 47;
            label29.Text = "Ингредиенты";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(690, 358);
            label28.Name = "label28";
            label28.Size = new Size(117, 15);
            label28.TabIndex = 46;
            label28.Text = "Доступные бортики";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(544, 358);
            label27.Name = "label27";
            label27.Size = new Size(86, 15);
            label27.TabIndex = 45;
            label27.Text = "Бортик пиццы";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(404, 358);
            label26.Name = "label26";
            label26.Size = new Size(81, 15);
            label26.TabIndex = 44;
            label26.Text = "Ингредиенты";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(690, 277);
            label25.Name = "label25";
            label25.Size = new Size(38, 15);
            label25.TabIndex = 43;
            label25.Text = "Тесто";
            // 
            // button9
            // 
            button9.Location = new Point(704, 39);
            button9.Name = "button9";
            button9.Size = new Size(118, 26);
            button9.TabIndex = 42;
            button9.Text = "фильтровать";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(555, 14);
            label15.Name = "label15";
            label15.Size = new Size(114, 15);
            label15.TabIndex = 41;
            label15.Text = "Стоимость больше";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(406, 14);
            label16.Name = "label16";
            label16.Size = new Size(122, 15);
            label16.TabIndex = 40;
            label16.Text = "Фильтр по названию";
            // 
            // textBoxFiltPizza2
            // 
            textBoxFiltPizza2.Location = new Point(555, 42);
            textBoxFiltPizza2.Name = "textBoxFiltPizza2";
            textBoxFiltPizza2.Size = new Size(143, 23);
            textBoxFiltPizza2.TabIndex = 39;
            // 
            // textBoxFiltPizza1
            // 
            textBoxFiltPizza1.Location = new Point(406, 42);
            textBoxFiltPizza1.Name = "textBoxFiltPizza1";
            textBoxFiltPizza1.Size = new Size(143, 23);
            textBoxFiltPizza1.TabIndex = 38;
            // 
            // checkedListBoxFlitPizza1
            // 
            checkedListBoxFlitPizza1.FormattingEnabled = true;
            checkedListBoxFlitPizza1.Location = new Point(404, 90);
            checkedListBoxFlitPizza1.Name = "checkedListBoxFlitPizza1";
            checkedListBoxFlitPizza1.Size = new Size(137, 184);
            checkedListBoxFlitPizza1.TabIndex = 29;
            checkedListBoxFlitPizza1.ItemCheck += checkedListBoxFlitPizza1_ItemCheck;
            // 
            // checkedListBoxFlitPizza2
            // 
            checkedListBoxFlitPizza2.FormattingEnabled = true;
            checkedListBoxFlitPizza2.Location = new Point(547, 90);
            checkedListBoxFlitPizza2.Name = "checkedListBoxFlitPizza2";
            checkedListBoxFlitPizza2.Size = new Size(137, 184);
            checkedListBoxFlitPizza2.TabIndex = 28;
            checkedListBoxFlitPizza2.ItemCheck += checkedListBoxFlitPizza2_ItemCheck;
            // 
            // checkedListBoxFlitPizza3
            // 
            checkedListBoxFlitPizza3.FormattingEnabled = true;
            checkedListBoxFlitPizza3.Location = new Point(690, 90);
            checkedListBoxFlitPizza3.Name = "checkedListBoxFlitPizza3";
            checkedListBoxFlitPizza3.Size = new Size(137, 184);
            checkedListBoxFlitPizza3.TabIndex = 27;
            checkedListBoxFlitPizza3.ItemCheck += checkedListBoxFlitPizza3_ItemCheck;
            // 
            // buttonSaveChanges
            // 
            buttonSaveChanges.Location = new Point(687, 324);
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
            buttonDeletePizza.Location = new Point(420, 322);
            buttonDeletePizza.Name = "buttonDeletePizza";
            buttonDeletePizza.Size = new Size(118, 26);
            buttonDeletePizza.TabIndex = 25;
            buttonDeletePizza.Text = "Удалить";
            buttonDeletePizza.UseVisualStyleBackColor = true;
            buttonDeletePizza.Click += buttonDeletePizza_Click;
            // 
            // comboBoxPizzaMain
            // 
            comboBoxPizzaMain.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPizzaMain.FormattingEnabled = true;
            comboBoxPizzaMain.Location = new Point(690, 295);
            comboBoxPizzaMain.Name = "comboBoxPizzaMain";
            comboBoxPizzaMain.Size = new Size(121, 23);
            comboBoxPizzaMain.TabIndex = 24;
            // 
            // checkedListBoxIngredients
            // 
            checkedListBoxIngredients.FormattingEnabled = true;
            checkedListBoxIngredients.Location = new Point(401, 376);
            checkedListBoxIngredients.Name = "checkedListBoxIngredients";
            checkedListBoxIngredients.Size = new Size(137, 184);
            checkedListBoxIngredients.TabIndex = 23;
            // 
            // checkedListBoxBorder
            // 
            checkedListBoxBorder.FormattingEnabled = true;
            checkedListBoxBorder.Location = new Point(544, 376);
            checkedListBoxBorder.Name = "checkedListBoxBorder";
            checkedListBoxBorder.Size = new Size(137, 184);
            checkedListBoxBorder.TabIndex = 22;
            checkedListBoxBorder.ItemCheck += checkedListBoxBorder_ItemCheck;
            // 
            // buttonEditPizza
            // 
            buttonEditPizza.Location = new Point(544, 324);
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
            checkedListBoxBordersList.Location = new Point(687, 376);
            checkedListBoxBordersList.Name = "checkedListBoxBordersList";
            checkedListBoxBordersList.Size = new Size(137, 184);
            checkedListBoxBordersList.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(544, 277);
            label8.Name = "label8";
            label8.Size = new Size(59, 15);
            label8.TabIndex = 18;
            label8.Text = "Название";
            // 
            // textBoxNamePizza
            // 
            textBoxNamePizza.Location = new Point(544, 295);
            textBoxNamePizza.Name = "textBoxNamePizza";
            textBoxNamePizza.Size = new Size(143, 23);
            textBoxNamePizza.TabIndex = 16;
            // 
            // button6
            // 
            button6.Location = new Point(420, 295);
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
            tabPage5.Controls.Add(label24);
            tabPage5.Controls.Add(label23);
            tabPage5.Controls.Add(label22);
            tabPage5.Controls.Add(label21);
            tabPage5.Controls.Add(label20);
            tabPage5.Controls.Add(label19);
            tabPage5.Controls.Add(label18);
            tabPage5.Controls.Add(label17);
            tabPage5.Controls.Add(label7);
            tabPage5.Controls.Add(buttonOpenFilt);
            tabPage5.Controls.Add(checkBox1);
            tabPage5.Controls.Add(buttonOpenForm);
            tabPage5.Controls.Add(comboBoxForPizzaMainInOrder);
            tabPage5.Controls.Add(comboBoxForPizzaA);
            tabPage5.Controls.Add(comboBoxForPizzaB);
            tabPage5.Controls.Add(checkedListBoxForPizzaInOrder2);
            tabPage5.Controls.Add(buttonForAddInOrder);
            tabPage5.Controls.Add(checkedListBoxForPizzaInOrder);
            tabPage5.Controls.Add(numericUpDownForCountPizza);
            tabPage5.Controls.Add(checkBoxForDouble);
            tabPage5.Controls.Add(comboBoxForSizePizza);
            tabPage5.Controls.Add(button4);
            tabPage5.Controls.Add(dataGridView6);
            tabPage5.Controls.Add(textBoxComment);
            tabPage5.Controls.Add(dateTimePicker1);
            tabPage5.Controls.Add(dataGridView5);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(830, 563);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Заказы";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(396, 488);
            label24.Name = "label24";
            label24.Size = new Size(130, 15);
            label24.TabIndex = 34;
            label24.Text = "Комментарий к заказу";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(519, 279);
            label23.Name = "label23";
            label23.Size = new Size(92, 15);
            label23.TabIndex = 33;
            label23.Text = "Пиццы в заказе";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(667, 84);
            label22.Name = "label22";
            label22.Size = new Size(119, 15);
            label22.TabIndex = 32;
            label22.Text = "Вид 2-ой половинки";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(518, 84);
            label21.Name = "label21";
            label21.Size = new Size(119, 15);
            label21.TabIndex = 31;
            label21.Text = "Вид 1-ой половинки";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(667, 44);
            label20.Name = "label20";
            label20.Size = new Size(138, 15);
            label20.TabIndex = 30;
            label20.Text = "Бортик 2-ой половинки";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(518, 44);
            label19.Name = "label19";
            label19.Size = new Size(138, 15);
            label19.TabIndex = 29;
            label19.Text = "Бортик 1-ой половинки";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(386, 55);
            label18.Name = "label18";
            label18.Size = new Size(78, 15);
            label18.TabIndex = 28;
            label18.Text = "Тесто пиццы";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(534, 3);
            label17.Name = "label17";
            label17.Size = new Size(103, 15);
            label17.TabIndex = 27;
            label17.Text = "Количество пицц";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(386, 3);
            label7.Name = "label7";
            label7.Size = new Size(87, 15);
            label7.TabIndex = 26;
            label7.Text = "Размер пиццы";
            // 
            // buttonOpenFilt
            // 
            buttonOpenFilt.Location = new Point(16, 535);
            buttonOpenFilt.Name = "buttonOpenFilt";
            buttonOpenFilt.Size = new Size(103, 23);
            buttonOpenFilt.TabIndex = 25;
            buttonOpenFilt.Text = "фильтровать";
            buttonOpenFilt.UseVisualStyleBackColor = true;
            buttonOpenFilt.Click += buttonOpenFilt_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(688, 455);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(86, 19);
            checkBox1.TabIndex = 24;
            checkBox1.Text = "Отложить?";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // buttonOpenForm
            // 
            buttonOpenForm.Location = new Point(396, 155);
            buttonOpenForm.Name = "buttonOpenForm";
            buttonOpenForm.Size = new Size(95, 46);
            buttonOpenForm.TabIndex = 23;
            buttonOpenForm.Text = "Создать свою пиццу";
            buttonOpenForm.UseVisualStyleBackColor = true;
            buttonOpenForm.Click += buttonOpenForm_Click;
            // 
            // comboBoxForPizzaMainInOrder
            // 
            comboBoxForPizzaMainInOrder.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxForPizzaMainInOrder.FormattingEnabled = true;
            comboBoxForPizzaMainInOrder.Location = new Point(378, 73);
            comboBoxForPizzaMainInOrder.Name = "comboBoxForPizzaMainInOrder";
            comboBoxForPizzaMainInOrder.Size = new Size(121, 23);
            comboBoxForPizzaMainInOrder.TabIndex = 22;
            // 
            // comboBoxForPizzaA
            // 
            comboBoxForPizzaA.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxForPizzaA.FormattingEnabled = true;
            comboBoxForPizzaA.Location = new Point(518, 60);
            comboBoxForPizzaA.Name = "comboBoxForPizzaA";
            comboBoxForPizzaA.Size = new Size(121, 23);
            comboBoxForPizzaA.TabIndex = 21;
            // 
            // comboBoxForPizzaB
            // 
            comboBoxForPizzaB.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxForPizzaB.FormattingEnabled = true;
            comboBoxForPizzaB.Location = new Point(667, 60);
            comboBoxForPizzaB.Name = "comboBoxForPizzaB";
            comboBoxForPizzaB.Size = new Size(121, 23);
            comboBoxForPizzaB.TabIndex = 20;
            // 
            // checkedListBoxForPizzaInOrder2
            // 
            checkedListBoxForPizzaInOrder2.FormattingEnabled = true;
            checkedListBoxForPizzaInOrder2.Location = new Point(667, 102);
            checkedListBoxForPizzaInOrder2.Name = "checkedListBoxForPizzaInOrder2";
            checkedListBoxForPizzaInOrder2.Size = new Size(124, 166);
            checkedListBoxForPizzaInOrder2.TabIndex = 19;
            checkedListBoxForPizzaInOrder2.ItemCheck += checkedListBoxForPizzaInOrder2_ItemCheck;
            // 
            // buttonForAddInOrder
            // 
            buttonForAddInOrder.Location = new Point(366, 228);
            buttonForAddInOrder.Name = "buttonForAddInOrder";
            buttonForAddInOrder.Size = new Size(146, 23);
            buttonForAddInOrder.TabIndex = 16;
            buttonForAddInOrder.Text = "добавить пиццу в заказ";
            buttonForAddInOrder.UseVisualStyleBackColor = true;
            buttonForAddInOrder.Click += buttonForAddInOrder_Click;
            // 
            // checkedListBoxForPizzaInOrder
            // 
            checkedListBoxForPizzaInOrder.FormattingEnabled = true;
            checkedListBoxForPizzaInOrder.Location = new Point(518, 102);
            checkedListBoxForPizzaInOrder.Name = "checkedListBoxForPizzaInOrder";
            checkedListBoxForPizzaInOrder.Size = new Size(124, 166);
            checkedListBoxForPizzaInOrder.TabIndex = 15;
            checkedListBoxForPizzaInOrder.ItemCheck += checkedListBoxForPizzaInOrder_ItemCheck;
            // 
            // numericUpDownForCountPizza
            // 
            numericUpDownForCountPizza.Location = new Point(519, 18);
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
            checkBoxForDouble.Location = new Point(660, 18);
            checkBoxForDouble.Name = "checkBoxForDouble";
            checkBoxForDouble.Size = new Size(145, 19);
            checkBoxForDouble.TabIndex = 13;
            checkBoxForDouble.Text = "Удвоить ингредиенты";
            checkBoxForDouble.UseVisualStyleBackColor = true;
            // 
            // comboBoxForSizePizza
            // 
            comboBoxForSizePizza.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxForSizePizza.FormattingEnabled = true;
            comboBoxForSizePizza.Location = new Point(378, 18);
            comboBoxForSizePizza.Name = "comboBoxForSizePizza";
            comboBoxForSizePizza.Size = new Size(121, 23);
            comboBoxForSizePizza.TabIndex = 12;
            // 
            // button4
            // 
            button4.Location = new Point(396, 535);
            button4.Name = "button4";
            button4.Size = new Size(95, 23);
            button4.TabIndex = 11;
            button4.Text = "Создать заказ";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // dataGridView6
            // 
            dataGridView6.AllowUserToAddRows = false;
            dataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView6.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView6.Location = new Point(378, 297);
            dataGridView6.Name = "dataGridView6";
            dataGridView6.ReadOnly = true;
            dataGridView6.Size = new Size(444, 150);
            dataGridView6.TabIndex = 10;
            // 
            // textBoxComment
            // 
            textBoxComment.Location = new Point(396, 506);
            textBoxComment.Name = "textBoxComment";
            textBoxComment.Size = new Size(426, 23);
            textBoxComment.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(396, 453);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 8;
            dateTimePicker1.Visible = false;
            // 
            // dataGridView5
            // 
            dataGridView5.AllowUserToAddRows = false;
            dataGridView5.AllowUserToDeleteRows = false;
            dataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView5.Location = new Point(3, 18);
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
            Text = "Конструктор Пиццы";
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
        private TextBox textBoxComment;
        private Button button4;
        private DataGridView dataGridView6;
        private Button buttonForAddInOrder;
        private CheckedListBox checkedListBoxForPizzaInOrder;
        private NumericUpDown numericUpDownForCountPizza;
        private CheckBox checkBoxForDouble;
        private ComboBox comboBoxForSizePizza;
        private ComboBox comboBoxForPizzaA;
        private ComboBox comboBoxForPizzaB;
        private CheckedListBox checkedListBoxForPizzaInOrder2;
        private ComboBox comboBoxForPizzaMainInOrder;
        private Button buttonOpenForm;
        private CheckBox checkBox1;
        private Label label9;
        private Label label10;
        private TextBox textBoxPriceFilter;
        private TextBox textBoxNameIngrFilter;
        private Button button5;
        private Button button7;
        private Label label11;
        private Label label12;
        private TextBox textBoxPizzaMainFilterPrice;
        private TextBox textBoxPizzaMainFilterName;
        private Button button8;
        private Label label13;
        private Label label14;
        private TextBox textBoxBordFiltPrice;
        private TextBox textBoxBordFiltName;
        private CheckedListBox checkedListBoxForBorderSort;
        private CheckedListBox checkedListBoxFlitPizza1;
        private CheckedListBox checkedListBoxFlitPizza2;
        private CheckedListBox checkedListBoxFlitPizza3;
        private Button button9;
        private Label label15;
        private Label label16;
        private TextBox textBoxFiltPizza2;
        private TextBox textBoxFiltPizza1;
        private Button buttonOpenFilt;
        private Label label22;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label7;
        private Label label31;
        private Label label30;
        private Label label29;
        private Label label28;
        private Label label27;
        private Label label26;
        private Label label25;
        private Label label24;
        private Label label23;
        private Label label33;
        private Label label32;
    }
}
