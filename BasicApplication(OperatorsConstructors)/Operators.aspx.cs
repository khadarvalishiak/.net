using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BasicApplication_Operators : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //  Validate.InnerText
        if(!IsPostBack)
        { 
            //By default Constructor will be called Here.
        GetValue sendName = new GetValue();
        bindUser.InnerText = sendName.userName;
        }
    }

    protected void Caluculate_Click(object sender, EventArgs e)
    {
        int c= Convert.ToInt32(AValue.Text) + Convert.ToInt32(BValue.Text);
        result.InnerText ="The value of A + b is "+  c.ToString();

    }  

    protected void sub_Click(object sender, EventArgs e)
    {
        int c = Convert.ToInt32(AValue.Text) - Convert.ToInt32(BValue.Text);
        result.InnerText = "The value of A - b is " + c.ToString();
    }

    protected void mul_Click(object sender, EventArgs e)
    {
        int c = Convert.ToInt32(AValue.Text) * Convert.ToInt32(BValue.Text);
        result.InnerText = "The value of A * b is " + c.ToString();
    }

    protected void div_Click(object sender, EventArgs e)
    {
        int c = Convert.ToInt32(AValue.Text) / Convert.ToInt32(BValue.Text);
        result.InnerText = "The value of A / b is " + c.ToString();
    }

    protected void modules_Click(object sender, EventArgs e)
    {
        int c = Convert.ToInt32(AValue.Text) % Convert.ToInt32(BValue.Text);
        result.InnerText = "The value of A % b is " + c.ToString();
    }

    protected void GetUserName_Click(object sender, EventArgs e)
    {

        // GetValue sendName = new GetValue(TextBox1.Text); //parameterised constructor will be invocekd here.
        //bindUser.InnerText = sendName.userName;


        //Seting like userDefined
        GetValue sn = new GetValue();
        sn.setName(TextBox1.Text);
        bindUser.InnerText = sn.userName;

    }
}