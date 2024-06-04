using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using System.IO.Ports;
using static OpenTK.Graphics.OpenGL.GL;
using AvionicsInstrumentControlDemo;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;
using GMap.NET;
using System.Linq;





namespace Youtube3D_Simulasyon
{

    public partial class Form1 : Form
    {
        
        bool cx = false, cy = false, cz = false;
        private int textureId;
        private float compassRotation = 0.0f;
        private int headingIntValue = 0;
        private double defaultLatitude = 37.873905;
        private double defaultLongitude = 37.873905;
        float width = 1f; // declare width as a class-level variable
        float height = 1f;
        private float rotationAngle = 0;
        double latTest=37.874;
        double lonTest=32.47;

        // harita işaretleyici

        GMarkerGoogle marker;
        int counter = 0;


        List<Tuple<DateTime, PointLatLng>> traveledPoints = new List<Tuple<DateTime, PointLatLng>>();

        

        // aktif deaktif buton 
        bool isPathVisible = false;

        GMapOverlay markersOverlay = new GMapOverlay("markers");
        GMapOverlay routeOverlay = new GMapOverlay("route");

        public Form1()
        {
            InitializeComponent();

            Timer timer = new Timer();
            timer.Interval = 300; // Set the timer to tick every 1 second
            timer.Tick += Zamanlayıcı_Tick; // Attach the Tick event handler
            timer.Start(); // Start the timer

            gMapControl1.DragButton = MouseButtons.Right;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.MinZoom = 1;
            gMapControl1.MaxZoom = 500;
            gMapControl1.Zoom = 21;

            gMapControl1.Overlays.Add(markersOverlay);
            gMapControl1.Overlays.Add(routeOverlay);



        }


        private void Form1_Load(object sender, EventArgs e)
        {


            string[] portlar = SerialPort.GetPortNames();  // seriye bağlı portların adını kaydcediyoruz
            foreach (string portAdi in portlar)
            {
                SerialPortComboBox.Items.Add(portAdi); ;   //Bu kısımda Serial Port seçebilmek için butona komut ekliyoruz, ekrandan seçebiliriz

            }



            Bitmap bitmap = new Bitmap(1000, 1000);
            //  compassPictureBox.Image = new Bitmap("compass300.png");

            
            TimerXYZ.Interval = 1;

           
           

            int width = bitmap.Width;  // logo genişlik uzunluk
            int height = bitmap.Height;

            byte[] imageData = new byte[width * height * 4];
            //  int width = ...; // logo genişlikl
            //  int height = ...; // logo uzunluk
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    // Get the color of the current pixel
                    Color color = bitmap.GetPixel(x, y);

                    // Calculate the index into the byte array
                    int index = (y * width + x) * 4;

                    // Store the color data in the byte array
                    imageData[index] = color.R;
                    imageData[index + 1] = color.G;
                    imageData[index + 2] = color.B;
                    imageData[index + 3] = color.A;
                }
            }

            

        }

      

        private void lblY_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SerialPortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TelemetreButton_Click(object sender, EventArgs e)
        {
            OkumaNesnesi.BaudRate = Convert.ToInt32(BaudRateTextBox.Text);
            OkumaNesnesi.PortName = SerialPortComboBox.Text;  //boudrateleri eşitliyoruz burada
            try                                                               //textboxda string okunduğundan integera çeviriyoruz
            {
                OkumaNesnesi.PortName = SerialPortComboBox.Text;   //hangi porttan bağlandığımızı anlıyoruz bu kısımda

                if (!OkumaNesnesi.IsOpen)
                {
                    Zamanlayıcı.Start();         //Bu kısımda bağlanıyoruz,eğer bir kez daha bağlanırsak sorun olabilir 
                    OkumaNesnesi.Open();
                    btnDurdur.Enabled = true;
                    TelemetreButton.Enabled = false;




                }
            }
            catch (Exception)
            {
                MessageBox.Show("BAĞLANTI KURULAMADI");
                btnDurdur.Enabled = true;

            }
        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            OkumaNesnesi.Close();
            Zamanlayıcı.Stop();
            TelemetreButton.Enabled = true;
            btnDurdur.Enabled = false;
            MessageBox.Show("Bağlantı Kesildi");

        }

        private void Zamanlayıcı_Tick(object sender, EventArgs e)
        {
            try
            {
                string sonuc = OkumaNesnesi.ReadExisting();
                string[] paket = sonuc.Split('*');

                double latitude = Convert.ToDouble(paket[0]);
                double longitude = Convert.ToDouble(paket[1]);

                int heading = Convert.ToInt32(paket[4]); // Extract heading from packet
                int altitude = Convert.ToInt32(paket[5]);
                // int temp = -Convert.ToInt32(paket[1]);
                int altitudex = Convert.ToInt32(paket[2]);
                int altitudey = Convert.ToInt32(paket[3]);

                compassLabel.Text = paket[4];
                headingIndicatorInstrumentControl2.SetHeadingIndicatorParameters(heading);

                altimeterInstrumentControl2.SetAlimeterParameters(altitude);

                attitudeIndicatorInstrumentControl1.SetAttitudeIndicatorParameters(altitudex, altitudey);

                // Set map position to the current location
                if (!testMode)
                {
                    gMapControl1.Position = new GMap.NET.PointLatLng(latitude / 1000000, longitude / 1000000);

                    // Add a marker every second
                    marker = new GMarkerGoogle(new PointLatLng(latitude / 1000000, longitude / 1000000), GMarkerGoogleType.red);
                    markersOverlay.Markers.Add(marker);
                }
                else
                {
                    // Simulate movement at a walking speed in test mode
                    double walkingSpeed = 0.00001; // Adjust the value as needed
                    latTest += walkingSpeed;
                    lonTest += walkingSpeed;

                    // gMapControl1.Position = new GMap.NET.PointLatLng(latitude/1000000, longitude/1000000);
                    // Add a marker every second
                    marker = new GMarkerGoogle(new PointLatLng(latTest, lonTest), GMarkerGoogleType.red);
                    markersOverlay.Markers.Add(marker);
                }

                LatitudeTextBox.Text = paket[0];
                LongitudeTextBox.Text = paket[1];
               

                // Remove the marker 
                if (markersOverlay.Markers.Count > 1)
                {
                    markersOverlay.Markers.RemoveAt(0);
                }

                // Update the route overlay with the latest traveled points if the path is visible
                if (isPathVisible)
                {
                    DateTime timestamp = DateTime.Now;
                    PointLatLng point;

                    if (!testMode)
                    {
                        point = new PointLatLng(latitude / 1000000, longitude / 1000000);
                    }
                    else
                    {
                        point = new PointLatLng(latTest, lonTest);
                    }

                    traveledPoints.Add(new Tuple<DateTime, PointLatLng>(timestamp, point));

                    if (traveledPoints.Count > 1)
                    {
                        // Remove points older than the last "Show Traveled Path" button click
                        DateTime lastShowPathButtonClick = DateTime.MinValue; // Replace with the actual variable storing the last click time
                        var recentPoints = traveledPoints.Where(t => t.Item1 > lastShowPathButtonClick).Select(t => t.Item2);

                        GMapRoute route = new GMapRoute(recentPoints, "Traveled Path");
                        markersOverlay.Routes.Clear(); // Clear existing routes
                        markersOverlay.Routes.Add(route); // Add the updated route
                    }
                }

                OkumaNesnesi.DiscardInBuffer();
            }
            catch
            {
                // Handle exceptions here
            }
        }



        public Bitmap MakeTransparent(Image img, Color color)
        {
            Bitmap bmp = new Bitmap(img);

            bmp.MakeTransparent(color);

            return bmp;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelx_Click(object sender, EventArgs e)
        {

        }

        private void labelX2_Click(object sender, EventArgs e)
        {

        }

        private void compassLabel_Click(object sender, EventArgs e)
        {

        }

        private void compassPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }



        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label110_Click(object sender, EventArgs e)
        {

        }

        private void trackBarAirSpeed_Scroll_1(object sender, EventArgs e, PaintEventArgs pe)
        {

            airSpeedInstrumentControl1.SetAirSpeedIndicatorParameters(trackBarAirSpeed.Value);

        }


        private void pictureBox6_Paint(object sender, PaintEventArgs e)
        {

            // Image img = Image.FromFile("path_to_your_image"); // Görüntünüzün yolunu buraya girin
            Color color = Color.Yellow; // Saydam yapmak istediğiniz rengi buraya girin

        }




        private void label60_Click(object sender, EventArgs e)
        {

        }

        private void label80_Click(object sender, EventArgs e)
        {

        }

        private void label90_Click(object sender, EventArgs e)
        {

        }

        private void label70_Click(object sender, EventArgs e)
        {

        }

        private void label100_Click(object sender, EventArgs e)
        {

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void label50_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void labelY2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void compass_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }



       

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {

        }
        private DateTime lastShowPathButtonClick = DateTime.MinValue;
        private void ShowPathButton_Click(object sender, EventArgs e)
        {
            // aç kapa
            isPathVisible = !isPathVisible;

            ShowPathButton.BackColor = isPathVisible ? Color.Gray : DefaultBackColor;

            if (isPathVisible)
            {
                // Update the timestamp for the last "Show Traveled Path" button click
                lastShowPathButtonClick = DateTime.Now;

                // Refresh the map to show the changes
                gMapControl1.Refresh();
            }
            else
            {
                // Remove the route overlay from the map
                routeOverlay.Routes.Clear();

                // Refresh the map to show the changes
                gMapControl1.Refresh();
            }
        }

        private void clearLinesButton_Click(object sender, EventArgs e)
        {
            // Clear the route overlay to remove the lines from the map
            markersOverlay.Routes.Clear();

            // Refresh the map to show the changes
            gMapControl1.Refresh();
        }
        private bool testMode = false;
        private void toggleTestModeButton_Click(object sender, EventArgs e)
        {
            // Toggle the test mode status
            testMode = !testMode;

            toggleTestModeButton.BackColor = testMode ? Color.Gray : DefaultBackColor;

            // Refresh the map to show the changes
            gMapControl1.Refresh();
        }

        private void glControl1_Load(object sender, EventArgs e)
        {
            GL.ClearColor(0.0f, 0.0f, 0.0f, 0.0f);
            GL.Enable(EnableCap.DepthTest);//sonradan yazdık
        }
        
        private void koni(float step, float topla, float radius1, float radius2, float dikey1, float dikey2)
        {
            float eski_step = 0.1f;
            float scaleFactor = 0.75f; // Bu kısımda kendi eklediğim şekillerin boyunu küçülttüm

            radius1 *= scaleFactor;
            radius2 *= scaleFactor;
            dikey1 *= scaleFactor;
            dikey2 *= scaleFactor;

            GL.Begin(BeginMode.Lines);//Y EKSEN CIZIM DAİRENİN
            while (step <= 360)
            {
                if (step < 45)
                    GL.Color3(Color.LightBlue);
                else if (step < 90)
                    GL.Color3(Color.Blue);
                else if (step < 135)
                    GL.Color3(Color.LightBlue);
                else if (step < 180)
                    GL.Color3(Color.Blue);
                else if (step < 225)
                    GL.Color3(Color.LightBlue);
                else if (step < 270)
                    GL.Color3(Color.Blue);
                else if (step < 315)
                    GL.Color3(Color.LightBlue);
                else if (step < 360)
                    GL.Color3(Color.Blue);


                float ciz1_x = (float)(radius1 * Math.Cos(step * Math.PI / 180F));
                float ciz1_y = (float)(radius1 * Math.Sin(step * Math.PI / 180F));
                GL.Vertex3(ciz1_x, dikey1, ciz1_y);

                float ciz2_x = (float)(radius2 * Math.Cos(step * Math.PI / 180F));
                float ciz2_y = (float)(radius2 * Math.Sin(step * Math.PI / 180F));
                GL.Vertex3(ciz2_x, dikey2, ciz2_y);
                step += topla;
            }
            GL.End();

            GL.Begin(BeginMode.Lines);
            step = eski_step;
            topla = step;
            while (step <= 180)// UST KAPAK
            {
                if (step < 45)
                    GL.Color3(Color.Blue);
                else if (step < 90)
                    GL.Color3(Color.LightSkyBlue);
                else if (step < 135)
                    GL.Color3(Color.Blue);
                else if (step < 180)
                    GL.Color3(Color.LightSkyBlue);
                else if (step < 225)
                    GL.Color3(Color.Blue);
                else if (step < 270)
                    GL.Color3(Color.LightSkyBlue);
                else if (step < 315)
                    GL.Color3(Color.Blue);
                else if (step < 360)
                    GL.Color3(Color.LightSkyBlue);


                float ciz1_x = (float)(radius2 * Math.Cos(step * Math.PI / 180F));
                float ciz1_y = (float)(radius2 * Math.Sin(step * Math.PI / 180F));
                GL.Vertex3(ciz1_x, dikey2, ciz1_y);

                float ciz2_x = (float)(radius2 * Math.Cos((step + 180) * Math.PI / 180F));
                float ciz2_y = (float)(radius2 * Math.Sin((step + 180) * Math.PI / 180F));
                GL.Vertex3(ciz2_x, dikey2, ciz2_y);

                GL.Vertex3(ciz1_x, dikey2, ciz1_y);
                GL.Vertex3(ciz2_x, dikey2, ciz2_y);
                step += topla;
            }
            step = eski_step;
            topla = step;
            GL.End();

            GL.Begin(BeginMode.Lines); // bu kısımda objeye 2 tane daha koni ekleyip şeklini değiştridm
            step = 0.1f; // Reset step
            while (step <= 360)
            {
                if (step < 45)
                    GL.Color3(Color.LightBlue);
                else if (step < 90)
                    GL.Color3(Color.Blue);
                else if (step < 135)
                    GL.Color3(Color.LightBlue);
                else if (step < 180)
                    GL.Color3(Color.Blue);
                else if (step < 225)
                    GL.Color3(Color.LightBlue);
                else if (step < 270)
                    GL.Color3(Color.Blue);
                else if (step < 315)
                    GL.Color3(Color.LightBlue);
                else if (step < 360)
                    GL.Color3(Color.Blue);

                float ciz1_x = (float)(radius2 * Math.Cos(step * Math.PI / 180F));
                float ciz1_y = (float)(radius2 * Math.Sin(step * Math.PI / 180F));
                GL.Vertex3(ciz1_x, dikey2, ciz1_y);

                float ciz2_x = (float)(radius1 * Math.Cos(step * Math.PI / 180F));
                float ciz2_y = (float)(radius1 * Math.Sin(step * Math.PI / 180F));
                GL.Vertex3(ciz2_x, dikey2 + (dikey2 - dikey1), ciz2_y); // Adjust the height as needed
                step += topla;
            }
            GL.End();
        }


        private void Pervane(float yukseklik, float uzunluk, float kalinlik, float egiklik)
        {
            float radius = 10, angle = 45.0f;
            GL.Begin(BeginMode.Quads);

            GL.Color3(Color.Black);
            GL.Vertex3(uzunluk, yukseklik, kalinlik);
            GL.Vertex3(uzunluk, yukseklik + egiklik, -kalinlik);
            GL.Vertex3(0.0, yukseklik + egiklik, -kalinlik);
            GL.Vertex3(0.0, yukseklik, kalinlik);

            GL.Color3(Color.Black);
            GL.Vertex3(-uzunluk, yukseklik + egiklik, kalinlik);
            GL.Vertex3(-uzunluk, yukseklik, -kalinlik);
            GL.Vertex3(0.0, yukseklik, -kalinlik);
            GL.Vertex3(0.0, yukseklik + egiklik, kalinlik);

            GL.Color3(Color.Gray);
            GL.Vertex3(kalinlik, yukseklik, -uzunluk);
            GL.Vertex3(-kalinlik, yukseklik + egiklik, -uzunluk);
            GL.Vertex3(-kalinlik, yukseklik + egiklik, 0.0);//+
            GL.Vertex3(kalinlik, yukseklik, 0.0);//-

            GL.Color3(Color.Gray);
            GL.Vertex3(kalinlik, yukseklik + egiklik, +uzunluk);
            GL.Vertex3(-kalinlik, yukseklik, +uzunluk);
            GL.Vertex3(-kalinlik, yukseklik, 0.0);
            GL.Vertex3(kalinlik, yukseklik + egiklik, 0.0);
            GL.End();

        }


    }



}


