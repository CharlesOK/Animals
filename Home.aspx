<%@ Page Language="C#" MasterPageFile="/shared/AnimalMasterPage.master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="FinalProject.Home" Title=" Welcome to  the Animal Kingdom "  %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet"  href="/Stylesheet/styles.css" type="text/css" />
    <link rel="preconnect" href="https://fonts.googleapis.com"/>
<link rel="preconnect" href="https://fonts.gstatic.com" crossorigin=""/>
<link href="https://fonts.googleapis.com/css2?family=DynaPuff&display=swap" rel="stylesheet"/>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Welcome to the Animal Kingdom</h3>
    <br />  
    <div>
    <p>Welcome to the Animal Kingdom website, below is an image gallery of the animals you could possibly learn about</p>
        </div>
    <div>
        <asp:Image ID="elephant" runat="server" AlternateText="An African Elephant" ImageAlign="left" ImageUrl="/images/elephant.jpg" />
        <asp:Image ID="lion" runat="server" AlternateText="An African Lion" ImageAlign="left" ImageUrl="/images/lion.jpg" />
         <asp:Image ID="cat" runat="server" AlternateText="A Cat" ImageAlign="top" ImageUrl="/images/cat.jpg" />
        <asp:Image ID="chameleon" runat="server" AlternateText="A Chameloen" ImageAlign="left" ImageUrl="/images/chameleon.jpg" />
         <asp:Image ID="cheetah" runat="server" AlternateText="An African Cheetah" ImageAlign="left" ImageUrl="/images/cheetah2.jpg" />
        <asp:Image ID="crocodile" runat="server" AlternateText="A Crocodile" ImageAlign="left" ImageUrl="/images/crocodile.jpg" />
         <asp:Image ID="dog" runat="server" AlternateText="A Dog" ImageAlign="left" ImageUrl="/images/dog2.jpg" />
        <asp:Image ID="horse" runat="server" AlternateText="A Horse" ImageAlign="top" ImageUrl="/images/horse2.jpg" />
         <asp:Image ID="komodo" runat="server" AlternateText="A Komodo Dragon" ImageAlign="left" ImageUrl="/images/komodo.jpg" />
        <asp:Image ID="snake" runat="server" AlternateText="A Snake" ImageAlign="left" ImageUrl="/images/snake.jpg" />
         <asp:Image ID="turtle" runat="server" AlternateText="A Turtle" ImageAlign="left" ImageUrl="/images/turtle2.jpg" />
         <asp:Image ID="lizard" runat="server" AlternateText="A Lizard" ImageAlign="top" ImageUrl="/images/lizard2.jpg"  />
    </div>
    
</asp:Content>