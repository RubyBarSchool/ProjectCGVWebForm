﻿using ProjectCSharpCGV.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectCSharpCGV.View.Accountxx
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.txtPass.Text = "";
                this.txtEmailAndPhone.Text = "";
                
            }
        }

        protected void btLogin_Click(object sender, EventArgs e)
        {
            string username = this.txtEmailAndPhone.Text;
            string password = this.txtPass.Text;
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                
                    if (AccountDAO.checkLogin(username, password))
                    {
                    // Response.Redirect("../../Default.aspx");
                    Session["account"] = AccountDAO.getAccountByUsernameDetail(username);
                    if (this.cbRemember.Checked)
                    {
                       
                    
                        HttpCookie cok = new HttpCookie("username");
                        cok.Value = username;
                        Response.Cookies.Add(cok);
                        HttpCookie cok1 = new HttpCookie("password");
                        cok.Value = password;
                        Response.Cookies.Add(cok1);
                    }
                    // Response.Redirect("AccountDetail.aspx");
                    Response.Redirect("../Booking/ChoiseCinema.aspx");
                }
                    else
                    {
                        this.thongBaoNgoai.Text = "Username / Password is not correct!";
                    }                       
            }
            else
            {           
                this.thongBaoNgoai.Text = "Username / Password is Empty!";

            }
        }
    }
}