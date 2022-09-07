<%@ Page Language="C#" MasterPageFile="/shared/AnimalMasterPage.master" AutoEventWireup="true" CodeBehind="AnimalDetails.aspx.cs" Inherits="FinalProject.AnimalDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet"  href="/Stylesheet/styles.css" type="text/css" />
    <link rel="preconnect" href="https://fonts.googleapis.com"/>
<link rel="preconnect" href="https://fonts.gstatic.com" />
<link href="https://fonts.googleapis.com/css2?family=DynaPuff&display=swap" rel="stylesheet"/>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Animal Details</h3>
    <br />  
    <div>
    <p>Below are the details of the animals you have selected.</p>
        </div>

     <asp:Label ID="Animals" runat="server" Width="272px" Font-Size="Small" Font-Names="Verdana" Font-Bold="True"></asp:Label>
    <br /><br /><br />
  
</asp:Content>