﻿using ProjectCSharpCGV.App_Code;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjectCSharpCGV.Model;
namespace ProjectCSharpCGV.View.Accountxx
{
    public partial class AccountDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Account re = (Account)Session["account"];
                this.drRegion.DataSource = RegionDAO.getAllRegion();
                this.drRegion.DataTextField = "name";
                 Area r = re.Areax;
                this.drRegion.DataValueField = "id";
                this.drRegion.SelectedValue = r.ID.ToString();
                this.drRegion.DataBind();

                this.drSite.DataSource = SiteDAO.getAllSite();
                this.drSite.DataTextField = "name";
                this.drSite.DataValueField = "id";
                Model.Theart th = re.Thearts;
                this.drSite.SelectedValue = th.ID.ToString();
                this.drSite.DataBind();

                this.txtName.Text = re.Name;
                this.txtPhone.Text = re.Phone;
                this.txtEmail.Text = re.Gmail;
                this.txtUsername.Text = re.UserName;
                this.txtPass.Text = re.PassWord;
                this.txtNgaySinh.Text = re.DOB.ToString();
                if (re.Gender)
                {
                    this.rdMale.Checked = true;
                }
                else
                {
                    this.rdFemale.Checked = true;
                }
                
            }
        }

        protected void btSave_Click(object sender, EventArgs e)
        {
            string name = this.txtName.Text;
            string phone = this.txtPhone.Text;
            bool gender = true;
            if (this.rdFemale.Checked) {
                gender = false;
            }
            int idKhuVuc = Convert.ToInt32(this.drRegion.SelectedValue);
            Account re = (Account)Session["account"];
            if (AccountDAO.updateAccount(name, phone, gender, idKhuVuc, re.UserName))
            {
                Response.Redirect("../../Default.aspx");
            }
        }
    }
}