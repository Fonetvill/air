
namespace main
{
    partial class ViewFlights
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label flightNumberLabel;
            System.Windows.Forms.Label departureAirportLabel;
            System.Windows.Forms.Label arrivalAirportLabel;
            this.airDataSet = new main.airDataSet();
            this.flightsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flightsTableAdapter = new main.airDataSetTableAdapters.FlightsTableAdapter();
            this.tableAdapterManager = new main.airDataSetTableAdapters.TableAdapterManager();
            this.flightsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.flightNumberComboBox = new System.Windows.Forms.ComboBox();
            this.departureAirportComboBox = new System.Windows.Forms.ComboBox();
            this.arrivalAirportComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.CancellBtn = new System.Windows.Forms.Button();
            this.FilterBtn = new System.Windows.Forms.Button();
            flightNumberLabel = new System.Windows.Forms.Label();
            departureAirportLabel = new System.Windows.Forms.Label();
            arrivalAirportLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.airDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flightNumberLabel
            // 
            flightNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            flightNumberLabel.AutoSize = true;
            flightNumberLabel.Location = new System.Drawing.Point(30, 19);
            flightNumberLabel.Name = "flightNumberLabel";
            flightNumberLabel.Size = new System.Drawing.Size(77, 13);
            flightNumberLabel.TabIndex = 1;
            flightNumberLabel.Text = "Номер рейса:";
            // 
            // departureAirportLabel
            // 
            departureAirportLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            departureAirportLabel.AutoSize = true;
            departureAirportLabel.Location = new System.Drawing.Point(180, 22);
            departureAirportLabel.Name = "departureAirportLabel";
            departureAirportLabel.Size = new System.Drawing.Size(82, 13);
            departureAirportLabel.TabIndex = 3;
            departureAirportLabel.Text = "Место вылета:";
            // 
            // arrivalAirportLabel
            // 
            arrivalAirportLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            arrivalAirportLabel.AutoSize = true;
            arrivalAirportLabel.Location = new System.Drawing.Point(395, 22);
            arrivalAirportLabel.Name = "arrivalAirportLabel";
            arrivalAirportLabel.Size = new System.Drawing.Size(86, 13);
            arrivalAirportLabel.TabIndex = 5;
            arrivalAirportLabel.Text = "Место прилёта:";
            // 
            // airDataSet
            // 
            this.airDataSet.DataSetName = "airDataSet";
            this.airDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // flightsBindingSource
            // 
            this.flightsBindingSource.DataMember = "Flights";
            this.flightsBindingSource.DataSource = this.airDataSet;
            // 
            // flightsTableAdapter
            // 
            this.flightsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccountsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookingsTableAdapter = null;
            this.tableAdapterManager.FlightHistoryTableAdapter = null;
            this.tableAdapterManager.FlightsTableAdapter = this.flightsTableAdapter;
            this.tableAdapterManager.PassengersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = main.airDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // flightsDataGridView
            // 
            this.flightsDataGridView.AllowUserToDeleteRows = false;
            this.flightsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flightsDataGridView.AutoGenerateColumns = false;
            this.flightsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.flightsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewCheckBoxColumn1});
            this.flightsDataGridView.DataSource = this.flightsBindingSource;
            this.flightsDataGridView.Location = new System.Drawing.Point(12, 89);
            this.flightsDataGridView.Name = "flightsDataGridView";
            this.flightsDataGridView.ReadOnly = true;
            this.flightsDataGridView.Size = new System.Drawing.Size(784, 349);
            this.flightsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "FlightId";
            this.dataGridViewTextBoxColumn1.HeaderText = "FlightId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FlightNumber";
            this.dataGridViewTextBoxColumn2.HeaderText = "Номер рейса";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DepartureAirport";
            this.dataGridViewTextBoxColumn3.HeaderText = "Место вылета";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ArrivalAirport";
            this.dataGridViewTextBoxColumn4.HeaderText = "Место прилёта";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DepartureTime";
            this.dataGridViewTextBoxColumn5.HeaderText = "Время вылета";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ArrivalTime";
            this.dataGridViewTextBoxColumn6.HeaderText = "Время прилёта";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "AvailableSeats";
            this.dataGridViewTextBoxColumn7.HeaderText = "Всего мест";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "IsCompleted";
            this.dataGridViewCheckBoxColumn1.HeaderText = "IsCompleted";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Visible = false;
            // 
            // flightNumberComboBox
            // 
            this.flightNumberComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flightNumberComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flightsBindingSource, "FlightNumber", true));
            this.flightNumberComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.flightsBindingSource, "FlightNumber", true));
            this.flightNumberComboBox.FormattingEnabled = true;
            this.flightNumberComboBox.Items.AddRange(new object[] {
            "Все",
            "JKL012",
            "MNO345",
            "PQR678",
            "ABC123",
            "DEF456",
            "GHI789",
            "FL011",
            "FL012",
            "FL013",
            "FL014",
            "FL015",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""});
            this.flightNumberComboBox.Location = new System.Drawing.Point(111, 16);
            this.flightNumberComboBox.Name = "flightNumberComboBox";
            this.flightNumberComboBox.Size = new System.Drawing.Size(63, 21);
            this.flightNumberComboBox.TabIndex = 2;
            this.flightNumberComboBox.SelectedIndexChanged += new System.EventHandler(this.flightNumberComboBox_SelectedIndexChanged);
            // 
            // departureAirportComboBox
            // 
            this.departureAirportComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.departureAirportComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flightsBindingSource, "DepartureAirport", true));
            this.departureAirportComboBox.FormattingEnabled = true;
            this.departureAirportComboBox.Items.AddRange(new object[] {
            "Все",
            "San Francisco",
            "Dubai",
            "Sydney",
            "New York",
            "London",
            "Tokyo"});
            this.departureAirportComboBox.Location = new System.Drawing.Point(268, 17);
            this.departureAirportComboBox.Name = "departureAirportComboBox";
            this.departureAirportComboBox.Size = new System.Drawing.Size(121, 21);
            this.departureAirportComboBox.TabIndex = 4;
            this.departureAirportComboBox.SelectedIndexChanged += new System.EventHandler(this.departureAirportComboBox_SelectedIndexChanged);
            // 
            // arrivalAirportComboBox
            // 
            this.arrivalAirportComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.arrivalAirportComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flightsBindingSource, "ArrivalAirport", true));
            this.arrivalAirportComboBox.FormattingEnabled = true;
            this.arrivalAirportComboBox.Items.AddRange(new object[] {
            "Все",
            "San Francisco",
            "Dubai",
            "Sydney",
            "New York",
            "London",
            "Tokyo"});
            this.arrivalAirportComboBox.Location = new System.Drawing.Point(487, 19);
            this.arrivalAirportComboBox.Name = "arrivalAirportComboBox";
            this.arrivalAirportComboBox.Size = new System.Drawing.Size(121, 21);
            this.arrivalAirportComboBox.TabIndex = 6;
            this.arrivalAirportComboBox.SelectedIndexChanged += new System.EventHandler(this.arrivalAirportComboBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.arrivalAirportComboBox);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(arrivalAirportLabel);
            this.groupBox1.Controls.Add(this.flightNumberComboBox);
            this.groupBox1.Controls.Add(flightNumberLabel);
            this.groupBox1.Controls.Add(departureAirportLabel);
            this.groupBox1.Controls.Add(this.departureAirportComboBox);
            this.groupBox1.Location = new System.Drawing.Point(65, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 71);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильтры";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(445, 46);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(149, 17);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Дальнее время прилёта";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(93, 46);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(159, 17);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Ближайшее время вылета";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // CancellBtn
            // 
            this.CancellBtn.Location = new System.Drawing.Point(727, 52);
            this.CancellBtn.Name = "CancellBtn";
            this.CancellBtn.Size = new System.Drawing.Size(58, 23);
            this.CancellBtn.TabIndex = 8;
            this.CancellBtn.Text = "Отмена ";
            this.CancellBtn.UseVisualStyleBackColor = true;
            this.CancellBtn.Click += new System.EventHandler(this.CancellBtn_Click);
            // 
            // FilterBtn
            // 
            this.FilterBtn.Location = new System.Drawing.Point(727, 21);
            this.FilterBtn.Name = "FilterBtn";
            this.FilterBtn.Size = new System.Drawing.Size(58, 23);
            this.FilterBtn.TabIndex = 9;
            this.FilterBtn.Text = "Фильтр";
            this.FilterBtn.UseVisualStyleBackColor = true;
            this.FilterBtn.Click += new System.EventHandler(this.FilterBtn_Click);
            // 
            // ViewFlights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(this.FilterBtn);
            this.Controls.Add(this.CancellBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flightsDataGridView);
            this.Name = "ViewFlights";
            this.Text = "ViewFlights";
            this.Load += new System.EventHandler(this.ViewFlights_Load);
            ((System.ComponentModel.ISupportInitialize)(this.airDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private airDataSet airDataSet;
        private System.Windows.Forms.BindingSource flightsBindingSource;
        private airDataSetTableAdapters.FlightsTableAdapter flightsTableAdapter;
        private airDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView flightsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.ComboBox flightNumberComboBox;
        private System.Windows.Forms.ComboBox departureAirportComboBox;
        private System.Windows.Forms.ComboBox arrivalAirportComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CancellBtn;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button FilterBtn;
    }
}