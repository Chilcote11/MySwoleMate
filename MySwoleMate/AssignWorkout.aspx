<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/MySwoleMate.Master" AutoEventWireup="true" CodeBehind="AssignWorkout.aspx.cs" Inherits="MySwoleMate.AssignWorkout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="first">
        <div class="container">
            <div class="row">
                <div class="col-xs-12 text-center">
                    <h1>Assign 5-Step Workout</h1>
                </div>
            </div>
            <div class="row">
                <div class="col-xs-8 text-center">
                    <!--ASP.NET Label Control will be here within the <div> element with an AssociatedControlID property set to the ID of the TextBox-->
                    <asp:Label ID="TraineeNameLabel" runat="server" CssClass="col-xs-4 control-label"></asp:Label>
                </div>
            </div>
        </div>
        <div class="col-xs-4">
            <asp:DropDownList ID="ddlWorkouts" runat="server" AppendDataBoundItems="true">
                <asp:ListItem Text="--Select Workout--" Value="0" />
            </asp:DropDownList>
            <div class="has-error">
                <span class="help-block">
                    <asp:RequiredFieldValidator ID="WorkoutRequired" runat="server" ErrorMessage="Please Select a Workout to Assign" InitialValue="0"
                        ControlToValidate="ddlWorkouts" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                </span>
            </div>
        </div>
        <div class="form-group">
            <div class="col-xs-4 col-xs-offset-4">
                <asp:Button ID="AssignWorkoutButton" runat="server" Text="Assign" CssClass="btn btn-success"
                    ValidationGroup="AllValidators" OnClick="AssignWorkoutButton_Click" />
                <a href="~/Trainees.aspx" runat="server" class="btn btn-default">Back</a>
            </div>
        </div>
    </section>
</asp:Content>
