﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FutureShow.aspx.cs" Inherits="ProjectCSharpCGV.View.Film.FutureShow" %>

<asp:Content ID="Content1" ContentPlaceHolderID="plCss" runat="server">
    <link href="../../Content/colobox.css" rel="stylesheet" />
    <link href="../../Content/custom-cgv.css" rel="stylesheet" />
    <link href="../../Content/g-erp-cgv.css" rel="stylesheet" />
    <link href="../../Content/madisonisland.css" rel="stylesheet" />
    <link href="../../Content/style.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" runat="server">
     <form runat="server" id="form1">
        <!-- code font end here -->
        <div class="main-container col1-layout">
            <div class="main">
                <div class="col-main">
                     <div class="page-title category-title">
                        <h1>Phim Sắp Chiếu</h1>
                    </div>
                    <div class="category-products cgv-movies">
                        <ul class="products-grid products-grid--max-4-col first last odd">
                            <% foreach (ProjectCSharpCGV.Model.Films fl in listFilm)
                                {%>
                            <li class="film-lists item last">
                                <span class="nmovie-rating nmovie-rating-c18"><%= fl.Ratedx.Title %></span>
                                <div class="ribon position-6"></div>

                                <div class="product-images">
                                    <a href="#" class="product-image">
                                        <img class="product-collection-image-2760" alt="" src="../../images/<%= fl.Image %>"/>
                                    </a>
                                    <div class="movie-technology">
                                    </div>
                                </div>

                                <div class="product-info" style="max-height: none; height: 116px; min-height: 31px;">
                                    <h2 class="product-name"><a><%= fl.Name %></a></h2>

                                    <div class="cgv-movie-info">
                                        <span class="cgv-info-bold">Thể loại: </span>
                                        <span class="cgv-info-normal"><%= fl.Genresx.Name %></span>
                                    </div>

                                    <div class="cgv-movie-info">
                                        <span class="cgv-info-bold">Thời lượng: </span>
                                        <span class="cgv-info-normal"><%= fl.Time %></span>
                                    </div>

                                    <div class="cgv-movie-info">
                                        <span class="cgv-info-bold">Khởi chiếu: </span>
                                        <span class="cgv-info-normal"><%= fl.ReleaseTime %></span>
                                    </div>
                                </div>
                            </li>
                            <%}%>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </form>
</asp:Content>
