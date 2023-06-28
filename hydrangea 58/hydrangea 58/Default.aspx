<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="hydrangea_58._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Главная</h1>
        <p class="lead">Добро пожаловать в интернет-магазин "Гортензия 58", наш питомник занимается выращиванием и продажей гортензий разных сортов. Ниже представлены ссылки, которые помогут вам ориентироваться по сайту</p>
      
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Каталог</h2>
            <p>
                Просмотр ассортимента предоставляемого магазином.
            </p>
            <p>
                <a class="btn btn-default" href="ProductList.aspx">Перейти &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
