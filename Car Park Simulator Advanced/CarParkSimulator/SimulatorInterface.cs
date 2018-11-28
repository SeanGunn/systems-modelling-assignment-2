using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Timers;

namespace CarParkSimulator
{
    public partial class SimulatorInterface : Form
    {
        private static System.Timers.Timer aTimer;
        // Attributes ///        
        private TicketMachine ticketMachine;
        private ActiveTickets activeTickets;
        private TicketValidator ticketValidator;
        private Barrier entryBarrier;
        private Barrier exitBarrier;
        private FullSign fullSign;
        private CarPark carPark;
        private EntrySensor entrySensor;
        private ExitSensor exitSensor;
        private PayStation payStation;

        /////////////////


        // Constructor //
        public SimulatorInterface()
        {
            InitializeComponent();
        }
        /////////////////


        // Operations ///
        private void ResetSystem(object sender, EventArgs e)
        {
            // STUDENTS:
            ///// Class contructors are not defined so there will be errors
            ///// This code is correct for the basic version though
            activeTickets = new ActiveTickets();
            ticketMachine = new TicketMachine(activeTickets);
            ticketValidator = new TicketValidator(activeTickets);
            entryBarrier = new Barrier();
            exitBarrier = new Barrier();
            fullSign = new FullSign();
            carPark = new CarPark(ticketMachine, ticketValidator, fullSign, entryBarrier, exitBarrier);
            entrySensor = new EntrySensor(carPark);
            exitSensor = new ExitSensor(carPark);
            payStation = new PayStation();

            ticketMachine.AssignCarPark(carPark);
            ticketValidator.AssignCarPark(carPark);

            /////////////////////////////////////////



            btnCarArrivesAtEntrance.Visible = true;
            btnDriverPressesForTicket.Visible = false;
            btnCarEntersCarPark.Visible = false;
            btnCarArrivesAtExit.Visible = false;
            btnDriverEntersTicket.Visible = false;
            btnCarExitsCarPark.Visible = false;
            payForIt.Visible = true;
            payForIt.Enabled = false;
            

            lblEntrySensor.Text = "False";
            lblEntryBarrier.Text = "False";
            lblExitSensor.Text = "False";
            lblExitBarrier.Text = "False";
            lblFullSign.Text = "False";
            lstActiveTickets.Items.Clear(); //clears the active tickets list

            lblTicketMachine.Text = "";
            lblTicketValidator.Text = "";
            


            UpdateDisplay();
        }

        private void CarArrivesAtEntrance(object sender, EventArgs e)
        {
            entrySensor.CarDetected(carPark);
            if (entrySensor.IsCarOnSensor())
            {
              lblTicketMachine.Text = ticketMachine.GetMessage("Please press to get a ticket");
              btnCarArrivesAtEntrance.Visible = false;
              btnDriverPressesForTicket.Visible = true;
              
              UpdateDisplay();
            }
            
        }

        private void DriverPressesForTicket(object sender, EventArgs e)
        {
            ticketMachine.PrintTicket(activeTickets, carPark);
            lblTicketMachine.Text = ticketMachine.GetMessage("Thank you, enjoy your stay");
            lstActiveTickets.Items.Add(activeTickets.GetTickets());
            btnDriverPressesForTicket.Visible = false;
            btnCarEntersCarPark.Visible = true;

            UpdateDisplay();
        }

        private void CarEntersCarPark(object sender, EventArgs e)
        {
            entrySensor.CarLeftSensor(carPark);
            if (!entrySensor.IsCarOnSensor())
            {
                lblTicketMachine.Text = ticketMachine.ClearMessage("");
           
                if (carPark.IsFull())
                {
                    fullSign.SetLit(1);
                }

                else
                {
                    fullSign.SetLit(0);
                }

                btnCarArrivesAtEntrance.Visible = true;
                btnCarEntersCarPark.Visible = false;
                if (!(btnCarArrivesAtExit.Visible || btnDriverEntersTicket.Visible || btnCarExitsCarPark.Visible))
                {
                    btnCarArrivesAtExit.Visible = true;
                }


            }
            UpdateDisplay();
        }

        private void CarArrivesAtExit(object sender, EventArgs e)
        {
            exitSensor.CarDetected(carPark);

            if (exitSensor.IsCarOnSensor())
            {
                lblTicketValidator.Text = ticketValidator.GetMessage("Please insert your ticket");
            }

            btnCarArrivesAtExit.Visible = false;
            btnDriverEntersTicket.Visible = true;
            
            UpdateDisplay();
        }

        private void DriverEntersTicket(object sender, EventArgs e)
        {
            ticketValidator.TicketEntered(carPark);
            lblTicketValidator.Text = ticketValidator.GetMessage("Please pay for the ticket");
            btnDriverEntersTicket.Visible = false;
            payForIt.Visible = true;
            payForIt.Enabled = true;

            UpdateDisplay();

        }

        private void pay_Click(object sender, EventArgs e)
        {
            payStation.PayForTicket(activeTickets);
            lstActiveTickets.Items.RemoveAt(0);
            lblTicketValidator.Text = ticketValidator.GetMessage("Thank you drive safely");
            payForIt.Enabled = true;
            btnCarExitsCarPark.Visible = true;
            payForIt.Enabled = false;
        }

        private void CarExitsCarPark(object sender, EventArgs e)
        {
            exitSensor.CarLeftSensor(carPark);

            if (!exitSensor.IsCarOnSensor())
            {
                lblTicketValidator.Text = ticketValidator.ClearMessage("");

                if (carPark.IsFull())
                {
                    fullSign.SetLit(1);
                }

                else
                {
                    fullSign.SetLit(0);
                }
                
                btnCarExitsCarPark.Visible = false;

                if (carPark.GetCurrentSpaces() < 5)
                {
                    btnCarArrivesAtExit.Visible = true;
                }

                if (carPark.HasSpace() && ((!btnCarEntersCarPark.Visible) || (!btnDriverPressesForTicket.Visible)))
                {
                    btnCarArrivesAtEntrance.Visible = true;
                }
            }
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            if(entrySensor.IsCarOnSensor())
            {
                lblEntrySensor.Text = "True";      //entry sensor
            }

            else
            {
                lblEntrySensor.Text = "False";     
            }

            if(entryBarrier.IsLifted())
            {
                lblEntryBarrier.Text = "True";     //entry barrier
            }
            else
            {
                lblEntryBarrier.Text = "False";
            }

            if (exitSensor.IsCarOnSensor())
            {
                lblExitSensor.Text = "True";       //exit sensor
                
            }
            else
            {
                lblExitSensor.Text = "False";
                
            }

            if (exitBarrier.IsLifted())
            {
                lblExitBarrier.Text = "True";          //exit barrier
            }

            else
            {
                lblExitBarrier.Text = "False";
            }

            if(fullSign.IsLit())
            {
                lblFullSign.Text = "True";             //fullsign
            }

            else
            {
                lblFullSign.Text = "False";
            }

            int spaces = carPark.GetCurrentSpaces();
            lblSpaces.Text = spaces.ToString();          //spaces
            UpdateVisulation();
            int currentSpaces = carPark.GetCurrentSpaces();
            if (carPark.IsFull())
            {
                btnCarArrivesAtEntrance.Visible = false;
            }
        }

        private void UpdateVisulation()
        {
            List<ListView> carParks = new List<ListView> { carPark1, carPark2, carPark3, carPark4, carPark5 };
            List<TextBox> carParkTNums = new List<TextBox> { carParkTNum1, carParkTNum2, carParkTNum3, carParkTNum4, carParkTNum5 };
            List<int> carParkSpaces = activeTickets.GetCarParkSpaces();
            int i = 0;
            while (i < 5)
            {
                if(carParkSpaces[i] == 0)
                {
                    carParks[i].BackColor = System.Drawing.Color.Green;
                    carParkTNums[i].Text = "Ticket #";
                }
                else
                {
                    carParks[i].BackColor = System.Drawing.Color.Firebrick;
                    carParkTNums[i].Text = "Ticket #" + carParkSpaces[i];
                }
                i++;
            }
        }
    }
}
