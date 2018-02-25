<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register2.aspx.cs" Inherits="courseMachineUi.Account.Register" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h2><%: Title %>.</h2>
    <h2 runat="server" id="registerTitle"></h2>
    <p class="text-danger">
        <asp:Literal runat="server" ID="ErrorMessage" />
    </p>
    <div runat = "server" class="form-horizontal">
        <h4>Create New Account</h4>
        <ul runat="server" id="createAccountLabel"></ul>
        <input type = "email" runat="server" id="userEmail" placeholder="email"/>
        <input type = "password" runat="server" id="userPassword" placeholder="password"/>
        <input type = "password" runat="server" id="passwordConfirm" placeholder="password again"/>
        <asp:Button runat="server" Text="Register" OnClick="AccountRegister_Click"/>
    </div>
</asp:Content>
