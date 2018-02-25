<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="courseHub.aspx.cs" Inherits="CustomerView.Views.Home.courseHub" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../../Scripts/Style/courseHub.css" rel="stylesheet" />
</head>
<body class="courseHub">
    <div class="filter">
        <div class="filterInput">
            <select ng-model="select_1">
                <option></option>
            </select>
        </div>
        <div class="filterFinal">
            <input type="text" ng-model="option_text"/>
        </div>
    </div>
    <div class="hub" ng-repeat="course in courses">
        <div class="courseBox">
            <h2>{{course.courseName}}</h2>
            <img src="{{course.img.path}}" alt="{{course.img.name}}" />
            <p>{{course.information.partial}}</p>
            <div class="courseBoxBtn">
                <input class="courseInfo" type="button" value="Details"/>
                <input class="courseBuy" type="button" value="Buy"/>
            </div>
            <div class="coursePrice">
                <p>{{course.information.partial}}</p>
                <p>{{course.price.amount + course.price.currency}}</p>
            </div>
        </div>
    </div>
</body>
</html>