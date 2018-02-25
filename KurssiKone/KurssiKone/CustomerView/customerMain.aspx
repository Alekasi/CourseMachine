<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="customerMain.aspx.cs" Inherits="CustomerView.customerMain" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" ng-app="courseApp">
<head runat="server">
    <script src="Scripts/angular.js"></script>
    <script src="Scripts/angular-route.js"></script>
    <script type="text/javascript" src="Scripts/Controllers/app.js"></script>
    <script type="text/javascript" src="Scripts/Controllers/CourseHub/courseController.js"></script>
    <link href="Scripts/Style/main.css" rel="stylesheet" />
    
    <title></title>

</head>
<body ng-controller="courseController">
    <div class="wrapper">
        <div class="header">tere</div>
        <div class="container" ng-view></div>
        <div class="footer">voihan vittu</div>
    </div>
</body>
</html>
