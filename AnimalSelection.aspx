<%@ Page Language="C#" MasterPageFile="/shared/AnimalMasterPage.master" AutoEventWireup="true" CodeBehind="AnimalSelection.aspx.cs" Inherits="FinalProject.AnimalSelection" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet"  href="/Stylesheet/styles.css" type="text/css" />
    <link rel="preconnect" href="https://fonts.googleapis.com"/>
<link rel="preconnect" href="https://fonts.gstatic.com" crossorigin=""/>
<link href="https://fonts.googleapis.com/css2?family=DynaPuff&display=swap" rel="stylesheet"/>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Animal Selection</h3>
    <br />  

    <div>
    <p>Animals textbox list</p>
        </div>

    <div>   
<p>Please type in an Animal you'd like to learn more about. The following animals can be typed in the textbox below (Cheetah, Elephant, Lion, Dog, Cat, Turtle, Snake, Lizard, Komodo Dragon, Horse, Crocodile and Chameleon). </p>
    </div>

    <div class="col-md-3">
        <asp:TextBox ID="animal_textBox" runat="server" TextMode="Multiline" />
    </div>

            

      

    <br />

    <div><p>Animals checkbox list</p></div>

      <div class="col-md-3">
        <asp:CheckBoxList ID="checkList" RepeatLayout="Flow" runat="server" Font-Names="DynaPuff, cursive"  />
        
    </div>


    <br />

    <div><p>Animals radiobutton list</p></div>


    <div> 
      <asp:RadioButtonList ID="RadioButton1" RepeatLayout="Flow" runat="server" Font-Names="DynaPuff, cursive"  />
    </div>

     <br />


        

    <br />
     <div class="row form-group">
                <div class="col-md-3"><asp:Button runat="server" Text="Details" CssClass="form-control btn btn-primary" OnClick="AnimalDetails"/></div>
            </div>
</asp:Content>