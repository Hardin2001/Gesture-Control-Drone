//-----------------------------------------------------------------------------
//	Copyright Endurance R/C 2008
//
//	PCTx/Servo Controller 9 Channel Sample Application
//
//	Please see the file license.txt for more info
//-----------------------------------------------------------------------------

#pragma once
#include "controller.h"
#undef GetObject

namespace controllerGUI
{
	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	public __gc class Form1 : public System::Windows::Forms::Form
	{	
	public:
		Form1(void)
		{
			InitializeComponent();
		}
		
	protected:
		void Dispose(Boolean disposing)
		{
			if (disposing && components)
			{
				components->Dispose();
			}
			__super::Dispose(disposing);
		}

	private: System::ComponentModel::IContainer *  components;
	private: System::Windows::Forms::HScrollBar *  hScrollBar1;
	private: System::Windows::Forms::HScrollBar *  hScrollBar2;
	private: System::Windows::Forms::HScrollBar *  hScrollBar3;
	private: System::Windows::Forms::HScrollBar *  hScrollBar4;
	private: System::Windows::Forms::HScrollBar *  hScrollBar5;
	private: System::Windows::Forms::HScrollBar *  hScrollBar6;
	private: System::Windows::Forms::HScrollBar *  hScrollBar7;
	private: System::Windows::Forms::HScrollBar *  hScrollBar8;
	private: System::Windows::Forms::HScrollBar *  hScrollBar9;
	private: System::Windows::Forms::Label *  label1;
	private: System::Windows::Forms::Label *  label2;
	private: System::Windows::Forms::Label *  label3;
	private: System::Windows::Forms::Label *  label4;
	private: System::Windows::Forms::Label *  label5;
	private: System::Windows::Forms::Label *  label6;
	private: System::Windows::Forms::Label *  label7;
	private: System::Windows::Forms::Label *  label8;
	private: System::Windows::Forms::Label *  label9;
	private: System::Windows::Forms::Label *  label10;
	private: System::Windows::Forms::Label *  label11;
	private: System::Windows::Forms::Label *  label12;
	private: System::Windows::Forms::Label *  label13;
	private: System::Windows::Forms::Label *  label14;
	private: System::Windows::Forms::Label *  label15;
	private: System::Windows::Forms::Label *  label16;
	private: System::Windows::Forms::Label *  label17;
	private: System::Windows::Forms::Label *  label18;
	private: System::Windows::Forms::Label *  label19;
	private: System::Windows::Forms::Label *  label20;
	private: System::Windows::Forms::Label *  label21;
	private: System::Windows::Forms::Label *  label22;
	private: System::Windows::Forms::Timer *  timer1;

	private: controller *c; //pointer to the PCTx/Servo Controller

		void InitializeComponent(void)
		{
			this->components = new System::ComponentModel::Container();
			System::Resources::ResourceManager *  resources = new System::Resources::ResourceManager(__typeof(controllerGUI::Form1));
			this->hScrollBar1 = new System::Windows::Forms::HScrollBar();
			this->label1 = new System::Windows::Forms::Label();
			this->label2 = new System::Windows::Forms::Label();
			this->label3 = new System::Windows::Forms::Label();
			this->hScrollBar2 = new System::Windows::Forms::HScrollBar();
			this->label4 = new System::Windows::Forms::Label();
			this->hScrollBar3 = new System::Windows::Forms::HScrollBar();
			this->label5 = new System::Windows::Forms::Label();
			this->hScrollBar4 = new System::Windows::Forms::HScrollBar();
			this->label6 = new System::Windows::Forms::Label();
			this->hScrollBar5 = new System::Windows::Forms::HScrollBar();
			this->label7 = new System::Windows::Forms::Label();
			this->hScrollBar6 = new System::Windows::Forms::HScrollBar();
			this->label8 = new System::Windows::Forms::Label();
			this->hScrollBar7 = new System::Windows::Forms::HScrollBar();
			this->label9 = new System::Windows::Forms::Label();
			this->hScrollBar8 = new System::Windows::Forms::HScrollBar();
			this->label10 = new System::Windows::Forms::Label();
			this->hScrollBar9 = new System::Windows::Forms::HScrollBar();
			this->label11 = new System::Windows::Forms::Label();
			this->label12 = new System::Windows::Forms::Label();
			this->label13 = new System::Windows::Forms::Label();
			this->label14 = new System::Windows::Forms::Label();
			this->label15 = new System::Windows::Forms::Label();
			this->label16 = new System::Windows::Forms::Label();
			this->label17 = new System::Windows::Forms::Label();
			this->label18 = new System::Windows::Forms::Label();
			this->label19 = new System::Windows::Forms::Label();
			this->timer1 = new System::Windows::Forms::Timer(this->components);
			this->label20 = new System::Windows::Forms::Label();
			this->label21 = new System::Windows::Forms::Label();
			this->label22 = new System::Windows::Forms::Label();
			this->SuspendLayout();
			// 
			// hScrollBar1
			// 
			this->hScrollBar1->LargeChange = 4;
			this->hScrollBar1->Location = System::Drawing::Point(104, 16);
			this->hScrollBar1->Maximum = 255;
			this->hScrollBar1->Name = S"hScrollBar1";
			this->hScrollBar1->Size = System::Drawing::Size(288, 16);
			this->hScrollBar1->TabIndex = 0;
			this->hScrollBar1->Value = 150;
			this->hScrollBar1->Scroll += new System::Windows::Forms::ScrollEventHandler(this, hScrollBar1_Scroll);
			// 
			// label1
			// 
			this->label1->Location = System::Drawing::Point(144, 240);
			this->label1->Name = S"label1";
			this->label1->Size = System::Drawing::Size(40, 13);
			this->label1->TabIndex = 1;
			this->label1->Text = S"Status:";
			// 
			// label2
			// 
			this->label2->Location = System::Drawing::Point(64, 16);
			this->label2->Name = S"label2";
			this->label2->Size = System::Drawing::Size(40, 16);
			this->label2->TabIndex = 2;
			this->label2->Text = S"150";
			// 
			// label3
			// 
			this->label3->Location = System::Drawing::Point(64, 40);
			this->label3->Name = S"label3";
			this->label3->Size = System::Drawing::Size(40, 16);
			this->label3->TabIndex = 11;
			this->label3->Text = S"150";
			// 
			// hScrollBar2
			// 
			this->hScrollBar2->LargeChange = 4;
			this->hScrollBar2->Location = System::Drawing::Point(104, 40);
			this->hScrollBar2->Maximum = 255;
			this->hScrollBar2->Name = S"hScrollBar2";
			this->hScrollBar2->Size = System::Drawing::Size(288, 16);
			this->hScrollBar2->TabIndex = 10;
			this->hScrollBar2->Value = 150;
			this->hScrollBar2->Scroll += new System::Windows::Forms::ScrollEventHandler(this, hScrollBar2_Scroll);
			// 
			// label4
			// 
			this->label4->Location = System::Drawing::Point(64, 64);
			this->label4->Name = S"label4";
			this->label4->Size = System::Drawing::Size(40, 16);
			this->label4->TabIndex = 13;
			this->label4->Text = S"150";
			// 
			// hScrollBar3
			// 
			this->hScrollBar3->LargeChange = 4;
			this->hScrollBar3->Location = System::Drawing::Point(104, 64);
			this->hScrollBar3->Maximum = 255;
			this->hScrollBar3->Name = S"hScrollBar3";
			this->hScrollBar3->Size = System::Drawing::Size(288, 16);
			this->hScrollBar3->TabIndex = 12;
			this->hScrollBar3->Value = 150;
			this->hScrollBar3->Scroll += new System::Windows::Forms::ScrollEventHandler(this, hScrollBar3_Scroll);
			// 
			// label5
			// 
			this->label5->Location = System::Drawing::Point(64, 88);
			this->label5->Name = S"label5";
			this->label5->Size = System::Drawing::Size(40, 16);
			this->label5->TabIndex = 15;
			this->label5->Text = S"150";
			// 
			// hScrollBar4
			// 
			this->hScrollBar4->LargeChange = 4;
			this->hScrollBar4->Location = System::Drawing::Point(104, 88);
			this->hScrollBar4->Maximum = 255;
			this->hScrollBar4->Name = S"hScrollBar4";
			this->hScrollBar4->Size = System::Drawing::Size(288, 16);
			this->hScrollBar4->TabIndex = 14;
			this->hScrollBar4->Value = 150;
			this->hScrollBar4->Scroll += new System::Windows::Forms::ScrollEventHandler(this, hScrollBar4_Scroll);
			// 
			// label6
			// 
			this->label6->Location = System::Drawing::Point(64, 184);
			this->label6->Name = S"label6";
			this->label6->Size = System::Drawing::Size(40, 16);
			this->label6->TabIndex = 23;
			this->label6->Text = S"150";
			// 
			// hScrollBar5
			// 
			this->hScrollBar5->LargeChange = 4;
			this->hScrollBar5->Location = System::Drawing::Point(104, 112);
			this->hScrollBar5->Maximum = 255;
			this->hScrollBar5->Name = S"hScrollBar5";
			this->hScrollBar5->Size = System::Drawing::Size(288, 16);
			this->hScrollBar5->TabIndex = 22;
			this->hScrollBar5->Value = 150;
			this->hScrollBar5->Scroll += new System::Windows::Forms::ScrollEventHandler(this, hScrollBar5_Scroll);
			// 
			// label7
			// 
			this->label7->Location = System::Drawing::Point(64, 136);
			this->label7->Name = S"label7";
			this->label7->Size = System::Drawing::Size(40, 16);
			this->label7->TabIndex = 21;
			this->label7->Text = S"150";
			// 
			// hScrollBar6
			// 
			this->hScrollBar6->LargeChange = 4;
			this->hScrollBar6->Location = System::Drawing::Point(104, 160);
			this->hScrollBar6->Maximum = 255;
			this->hScrollBar6->Name = S"hScrollBar6";
			this->hScrollBar6->Size = System::Drawing::Size(288, 16);
			this->hScrollBar6->TabIndex = 20;
			this->hScrollBar6->Value = 150;
			this->hScrollBar6->Scroll += new System::Windows::Forms::ScrollEventHandler(this, hScrollBar6_Scroll);
			// 
			// label8
			// 
			this->label8->Location = System::Drawing::Point(64, 160);
			this->label8->Name = S"label8";
			this->label8->Size = System::Drawing::Size(40, 16);
			this->label8->TabIndex = 19;
			this->label8->Text = S"150";
			// 
			// hScrollBar7
			// 
			this->hScrollBar7->LargeChange = 4;
			this->hScrollBar7->Location = System::Drawing::Point(104, 136);
			this->hScrollBar7->Maximum = 255;
			this->hScrollBar7->Name = S"hScrollBar7";
			this->hScrollBar7->Size = System::Drawing::Size(288, 16);
			this->hScrollBar7->TabIndex = 18;
			this->hScrollBar7->Value = 150;
			this->hScrollBar7->Scroll += new System::Windows::Forms::ScrollEventHandler(this, hScrollBar7_Scroll);
			// 
			// label9
			// 
			this->label9->Location = System::Drawing::Point(64, 112);
			this->label9->Name = S"label9";
			this->label9->Size = System::Drawing::Size(40, 16);
			this->label9->TabIndex = 17;
			this->label9->Text = S"150";
			// 
			// hScrollBar8
			// 
			this->hScrollBar8->LargeChange = 4;
			this->hScrollBar8->Location = System::Drawing::Point(104, 184);
			this->hScrollBar8->Maximum = 255;
			this->hScrollBar8->Name = S"hScrollBar8";
			this->hScrollBar8->Size = System::Drawing::Size(288, 16);
			this->hScrollBar8->TabIndex = 16;
			this->hScrollBar8->Value = 150;
			this->hScrollBar8->Scroll += new System::Windows::Forms::ScrollEventHandler(this, hScrollBar8_Scroll);
			// 
			// label10
			// 
			this->label10->Location = System::Drawing::Point(64, 208);
			this->label10->Name = S"label10";
			this->label10->Size = System::Drawing::Size(40, 16);
			this->label10->TabIndex = 25;
			this->label10->Text = S"150";
			// 
			// hScrollBar9
			// 
			this->hScrollBar9->LargeChange = 4;
			this->hScrollBar9->Location = System::Drawing::Point(104, 208);
			this->hScrollBar9->Maximum = 255;
			this->hScrollBar9->Name = S"hScrollBar9";
			this->hScrollBar9->Size = System::Drawing::Size(288, 16);
			this->hScrollBar9->TabIndex = 24;
			this->hScrollBar9->Value = 150;
			this->hScrollBar9->Scroll += new System::Windows::Forms::ScrollEventHandler(this, hScrollBar9_Scroll);
			// 
			// label11
			// 
			this->label11->Location = System::Drawing::Point(8, 16);
			this->label11->Name = S"label11";
			this->label11->Size = System::Drawing::Size(56, 16);
			this->label11->TabIndex = 26;
			this->label11->Text = S"Channel 1";
			// 
			// label12
			// 
			this->label12->Location = System::Drawing::Point(8, 40);
			this->label12->Name = S"label12";
			this->label12->Size = System::Drawing::Size(56, 16);
			this->label12->TabIndex = 27;
			this->label12->Text = S"Channel 2";
			// 
			// label13
			// 
			this->label13->Location = System::Drawing::Point(8, 64);
			this->label13->Name = S"label13";
			this->label13->Size = System::Drawing::Size(56, 16);
			this->label13->TabIndex = 28;
			this->label13->Text = S"Channel 3";
			// 
			// label14
			// 
			this->label14->Location = System::Drawing::Point(8, 88);
			this->label14->Name = S"label14";
			this->label14->Size = System::Drawing::Size(56, 16);
			this->label14->TabIndex = 29;
			this->label14->Text = S"Channel 4";
			// 
			// label15
			// 
			this->label15->Location = System::Drawing::Point(8, 112);
			this->label15->Name = S"label15";
			this->label15->Size = System::Drawing::Size(56, 16);
			this->label15->TabIndex = 30;
			this->label15->Text = S"Channel 5";
			// 
			// label16
			// 
			this->label16->Location = System::Drawing::Point(8, 136);
			this->label16->Name = S"label16";
			this->label16->Size = System::Drawing::Size(56, 16);
			this->label16->TabIndex = 31;
			this->label16->Text = S"Channel 6";
			// 
			// label17
			// 
			this->label17->Location = System::Drawing::Point(8, 160);
			this->label17->Name = S"label17";
			this->label17->Size = System::Drawing::Size(56, 16);
			this->label17->TabIndex = 32;
			this->label17->Text = S"Channel 7";
			// 
			// label18
			// 
			this->label18->Location = System::Drawing::Point(8, 184);
			this->label18->Name = S"label18";
			this->label18->Size = System::Drawing::Size(56, 16);
			this->label18->TabIndex = 33;
			this->label18->Text = S"Channel 8";
			// 
			// label19
			// 
			this->label19->Location = System::Drawing::Point(8, 208);
			this->label19->Name = S"label19";
			this->label19->Size = System::Drawing::Size(56, 16);
			this->label19->TabIndex = 34;
			this->label19->Text = S"Channel 9";
			// 
			// timer1
			// 
			this->timer1->Enabled = true;
			this->timer1->Interval = 50;
			this->timer1->Tick += new System::EventHandler(this, timer1_Tick);
			// 
			// label20
			// 
			this->label20->Image = (__try_cast<System::Drawing::Image *  >(resources->GetObject(S"label20.Image")));
			this->label20->Location = System::Drawing::Point(192, 238);
			this->label20->Name = S"label20";
			this->label20->Size = System::Drawing::Size(16, 16);
			this->label20->TabIndex = 35;
			// 
			// label21
			// 
			this->label21->Image = (__try_cast<System::Drawing::Image *  >(resources->GetObject(S"label21.Image")));
			this->label21->Location = System::Drawing::Point(192, 238);
			this->label21->Name = S"label21";
			this->label21->Size = System::Drawing::Size(16, 16);
			this->label21->TabIndex = 36;
			// 
			// label22
			// 
			this->label22->Location = System::Drawing::Point(224, 240);
			this->label22->Name = S"label22";
			this->label22->Size = System::Drawing::Size(80, 13);
			this->label22->TabIndex = 37;
			this->label22->Text = S"Not Connected";
			// 
			// Form1
			// 
			this->AutoScaleBaseSize = System::Drawing::Size(5, 13);
			this->ClientSize = System::Drawing::Size(408, 261);
			this->Controls->Add(this->label22);
			this->Controls->Add(this->label21);
			this->Controls->Add(this->label20);
			this->Controls->Add(this->label19);
			this->Controls->Add(this->label18);
			this->Controls->Add(this->label17);
			this->Controls->Add(this->label16);
			this->Controls->Add(this->label15);
			this->Controls->Add(this->label14);
			this->Controls->Add(this->label13);
			this->Controls->Add(this->label12);
			this->Controls->Add(this->label11);
			this->Controls->Add(this->label10);
			this->Controls->Add(this->hScrollBar9);
			this->Controls->Add(this->label6);
			this->Controls->Add(this->hScrollBar5);
			this->Controls->Add(this->label7);
			this->Controls->Add(this->hScrollBar6);
			this->Controls->Add(this->label8);
			this->Controls->Add(this->hScrollBar7);
			this->Controls->Add(this->label9);
			this->Controls->Add(this->hScrollBar8);
			this->Controls->Add(this->label5);
			this->Controls->Add(this->hScrollBar4);
			this->Controls->Add(this->label4);
			this->Controls->Add(this->hScrollBar3);
			this->Controls->Add(this->label3);
			this->Controls->Add(this->hScrollBar2);
			this->Controls->Add(this->label2);
			this->Controls->Add(this->label1);
			this->Controls->Add(this->hScrollBar1);
			this->Name = S"Form1";
			this->Text = S"Endurance R/C - 9 Channel Controller Sample";
			this->Load += new System::EventHandler(this, Form1_Load);
			this->ResumeLayout(false);

		}	

	private: System::Void Form1_Load(System::Object *  sender, System::EventArgs *  e)
			 {
				 c = new controller();	//create a new PCTx/Servo Controller object

				 if(c->connected == true) {
					label1->Text = "Connected";

					//Initial servo values
					hScrollBar1->Value = 150;
					hScrollBar2->Value = 150;
					hScrollBar3->Value = 150;
					hScrollBar4->Value = 150;
					hScrollBar5->Value = 150;
					hScrollBar6->Value = 150;
					hScrollBar7->Value = 150;
					hScrollBar8->Value = 150;
					hScrollBar9->Value = 150;
					
					this->timer1->Enabled = true;  //start the timer
				}
			 }

//called on a timer tick
private: bool update()
		 {
			 return c->send(hScrollBar1->Value,hScrollBar2->Value,hScrollBar3->Value,hScrollBar4->Value,
				 hScrollBar5->Value,hScrollBar6->Value,hScrollBar7->Value,hScrollBar8->Value,hScrollBar9->Value);
		 }

private: System::Void hScrollBar1_Scroll(System::Object *  sender, System::Windows::Forms::ScrollEventArgs *  e)
			{
				label2->Text = hScrollBar1->Value.ToString();
			}

private: System::Void hScrollBar2_Scroll(System::Object *  sender, System::Windows::Forms::ScrollEventArgs *  e)
		 {
				 label3->Text = hScrollBar2->Value.ToString();
		 }

private: System::Void hScrollBar3_Scroll(System::Object *  sender, System::Windows::Forms::ScrollEventArgs *  e)
		 {
				 label4->Text = hScrollBar3->Value.ToString();
		 }

private: System::Void hScrollBar4_Scroll(System::Object *  sender, System::Windows::Forms::ScrollEventArgs *  e)
		 {
				 label5->Text = hScrollBar4->Value.ToString();
		 }

private: System::Void hScrollBar5_Scroll(System::Object *  sender, System::Windows::Forms::ScrollEventArgs *  e)
		 {
				 label9->Text = hScrollBar5->Value.ToString();
		 }

private: System::Void hScrollBar6_Scroll(System::Object *  sender, System::Windows::Forms::ScrollEventArgs *  e)
		 {
				 label8->Text = hScrollBar6->Value.ToString();
		 }

private: System::Void hScrollBar7_Scroll(System::Object *  sender, System::Windows::Forms::ScrollEventArgs *  e)
		 {
				 label7->Text = hScrollBar7->Value.ToString();
		 }

private: System::Void hScrollBar8_Scroll(System::Object *  sender, System::Windows::Forms::ScrollEventArgs *  e)
		 {
				 label6->Text = hScrollBar8->Value.ToString();
		 }

private: System::Void hScrollBar9_Scroll(System::Object *  sender, System::Windows::Forms::ScrollEventArgs *  e)
		 {
				 label10->Text = hScrollBar9->Value.ToString();
		 }

//Called every 50ms
//Attempts to update the PCTx/Servo Controller with new data, if it cannot, it will attempt to connect to the 
//  PCTx/Servo Controller and try again
private: System::Void timer1_Tick(System::Object *  sender, System::EventArgs *  e)
		 {
				if(update()){
					label21->Visible = true;
					label22->Text = "Connected";
				}
				else {
					if(c->connect()){
						label21->Visible = true;
						label22->Text = "Connected";
					}
					else {
						label21->Visible = false;
						label22->Text = "Not Connected";
					}
				}
		 }
};
}