namespace Calculadora_oyi
{
    public partial class Form1 : Form
    {

        private double valor1;
        private double valor2;
        //variables tipo DOUBLE con el modificador de acceso PRIVATE para almacenar
        //el valor uno y el valor dos

        //Las variables double sirven para tener valores decimales

        private double resultado;

        private int operacion;

        private int tiempo;
       

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            //boton RAIZ
            
            valor1 = Convert.ToDouble(tbDisplay.Text);
            resultado = Math.Sqrt(valor1);
            tbDisplay.Text = resultado.ToString();
            tiempo = 1;
            
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            //numero 0
            switch (tiempo)
            {
                case 1:
                    tbDisplay.Text = "0";
                    break;
                case 2:
                    tbDisplay.Text = tbDisplay.Text + "0";
                    break;
            }
            tiempo = 2;
            //tbDisplay.Text = es para que escriba en TexBox lo que queremos
            //Le ponemos "tbDisplay.Text + " para que al valor de tbDisplay le concatene
            //el nuevo numero y se pueda esctibir mas de 1 digito "15 o 98 por ejemplo"
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            //boton punto
            tbDisplay.Text = tbDisplay.Text + ",";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //numero 1
            switch (tiempo)
            {
                case 1:
                    tbDisplay.Text = "1";
                    break;
                case 2:
                    tbDisplay.Text = tbDisplay.Text + "1";
                    break;
            }
            tiempo = 2;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            //numero 2
            switch (tiempo)
            {
                case 1:
                    tbDisplay.Text = "2";
                    break;
                case 2:
                    tbDisplay.Text = tbDisplay.Text + "2";
                    break;
            }
            tiempo = 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            //numero 3
            switch (tiempo)
            {
                case 1:
                    tbDisplay.Text = "3";
                    break;
                case 2:
                    tbDisplay.Text = tbDisplay.Text + "3";
                    break;
            }
            tiempo = 2;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            //numero 4
            switch (tiempo)
            {
                case 1:
                    tbDisplay.Text = "4";
                    break;
                case 2:
                    tbDisplay.Text = tbDisplay.Text + "4";
                    break;
            }
            tiempo = 2;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            //numero 5
            switch (tiempo)
            {
                case 1:
                    tbDisplay.Text = "5";
                    break;
                case 2:
                    tbDisplay.Text = tbDisplay.Text + "5";
                    break;
            }
            tiempo = 2;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            //numero 6
            switch (tiempo)
            {
                case 1:
                    tbDisplay.Text = "6";
                    break;
                case 2:
                    tbDisplay.Text = tbDisplay.Text + "6";
                    break;
            }
            tiempo = 2;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            //numero 7
            switch (tiempo)
            {
                case 1:
                    tbDisplay.Text = "7";
                    break;
                case 2:
                    tbDisplay.Text = tbDisplay.Text + "7";
                    break;
            }
            tiempo = 2;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            //numero 8
            switch (tiempo)
            {
                case 1:
                    tbDisplay.Text = "8";
                    break;
                case 2:
                    tbDisplay.Text = tbDisplay.Text + "8";
                    break;
            }
            tiempo = 2;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            //numero 9
            switch (tiempo)
            {
                case 1:
                    tbDisplay.Text = "9";
                    break;
                case 2:
                    tbDisplay.Text = tbDisplay.Text + "9";
                    break;
            }
            tiempo = 2;
            
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            // boton AC
            tbDisplay.Text = "";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            //boton igual
            
            valor2 = Convert.ToDouble(tbDisplay.Text);

            switch(operacion)
            {
                case 1:
                    resultado = valor1 + valor2;
                    break;
                case 2:
                    resultado = valor1 - valor2;
                    break;
                case 3:
                    resultado = valor1 * valor2;
                    break;
                case 4:
                    resultado = valor1 / valor2;
                    break;
               
            }

            tbDisplay.Text = resultado.ToString();

                tiempo = 1;



            //El elemento Switch nos permite evaluar una variable y realizar diferentes
            //cosas según el resultado de la evaluación. ejecute segun el valor anterior del caso

            //resultoado.ToString() lo que hace es llevar resultado a string para ser
            //mostrado en el display

            //string val1 = "205";
            //string val2 = "55";
            //int resultado = 0;
            //int valor1 = 0;
            //int valor2 = 0;
            //valor1 = convert.toint32(val1);
            //valor2 = convert.toint32(val2);
            //resultado = valor1 + valor2;
            //tbdisplay.text = resultado.tostring();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            //boton suma
            operacion = 1;
            valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = "";

        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            //boton resta
            operacion = 2;
            valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = "";

        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            //boton multiplicacion
            operacion = 3;
            valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = "";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            //boton division
            operacion = 4;
            valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = "";
        }
    }
}