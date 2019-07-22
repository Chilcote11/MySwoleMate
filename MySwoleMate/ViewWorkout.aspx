<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/MySwoleMate.Master" AutoEventWireup="true" CodeBehind="ViewWorkout.aspx.cs" Inherits="MySwoleMate.ViewWorkout" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="first">
        <div class="container">
            <div class="row">
                    <h1>5-Step Workout</h1>
            </div>
        </div>
        <div class="row">
            <asp:Label ID="NoWorkoutLabel" runat="server" CssClass="col-xs-4 control-label"></asp:Label>
        </div>
        <div class="row">
            <asp:Label ID="TraineeNameLabel" runat="server" CssClass="col-xs-4 control-label"></asp:Label>
        </div>
        <div class="row">
            <asp:Label ID="WorkoutNameLabel" runat="server" CssClass="col-xs-4 control-label"></asp:Label>
        </div>
        <div class="row">
            <asp:Label ID="Exercise1Label" runat="server" CssClass="col-xs-4 control-label"></asp:Label>
        </div>
        <div class="row">
            <asp:Label ID="Exercise2Label" runat="server" CssClass="col-xs-4 control-label"></asp:Label>
        </div>
        <div class="row">
            <asp:Label ID="Exercise3Label" runat="server" CssClass="col-xs-4 control-label"></asp:Label>
        </div>
        <div class="row">
            <asp:Label ID="Exercise4Label" runat="server" CssClass="col-xs-4 control-label"></asp:Label>
        </div>
        <div class="row">
            <asp:Label ID="Exercise5Label" runat="server" CssClass="col-xs-4 control-label"></asp:Label>
        </div>
        <div class="form-group">
            <div class="col-xs-4 col-xs-offset-4">
                <%--a href="~/AssignWorkout.aspx" runat="server" class="btn btn-default">Assign Workout</--%>
                <%--<a href="~/AssignWorkout.aspx?TraineeID={0}" runat="server" class="btn btn-default">Assign Workout</a>--%>
                <%--asp:HyperLinkField Text="Assign Workout" DataNavigateUrlFields="TraineeID"
                                DataNavigateUrlFormatString="~/AssignWorkout.aspx?TraineeID={0}" ControlStyle-CssClass="btn btn-success btn-xs"
                                ItemStyle-CssClass="text-center" /--%>
                    <!--neither of the lines above will work. the first creates a button, but needs TraineeID passed
                        I attempted to do this with line 39, but it doesn't work that way-->
                <asp:LinkButton ID="AssignWorkoutButton" runat="server" ControlStyle-CssClass="btn btn-success btn-xs"
                                ItemStyle-CssClass="text-center" OnClick="AssignWorkoutButton_Click">Assign Workout</asp:LinkButton>
                <a href="~/Trainees.aspx" runat="server" class="btn btn-default">Back</a>
            </div>
        </div>
    </section>
</asp:Content>
