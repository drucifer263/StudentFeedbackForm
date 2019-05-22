<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Processed.aspx.cs" Inherits="Project1.Processed" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Student Survey Processed</title>
    <!--Bootstrap Reference With JS Reference-->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" />
    <script src="https://code.jquery.com/jquery-3.1.1.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js"></script>
    <!-- Angular -->
    <script src="https://ajax.googleapis.com/ajax/libs/angularjs/1.2.5/angular.min.js"></script>
    <!-- My CSS and JS -->
    <link rel="stylesheet" type="text/css" href="myStyleSheet.css" />
    <script src="myJavaScript.js"></script>
    <link rel="shortcut icon" href="images/Tindex.ico" />
</head>
<body>
    <!--Nav bar-->
    <nav class="navBar">
        <div id="nav-btn">
            <img id="nav-icon" src="images/menu.png" alt="Menu Icon" />
        </div>
        <ul class="box2 navList show ">
            <li><a class="highlight" href="http://cis-iis2.temple.edu/Spring2019/CIS3342_tua07182/">Lab Page</a></li>
            <li><a href="#top">Top</a></li>
            <li><a href="#footer">Footer</a></li>
        </ul>
    </nav>
    <!--Header Jumbotron-->
    <header id="header1" class="jumbotron">
        <h1 id="top">Class Survey Results</h1>
    </header>
    <main>
        <!--Main Form-->
        <form id="frmResults" runat="server">
            <div>
                <!--Student info-->
                <asp:Label ID="displayInfo" runat="server" Text="Student Info: " CssClass="alert-info"></asp:Label>
                <br />
                <br />
                <!--Course info-->
                <asp:Label ID="displayCourse" runat="server" Text="Course Info: " CssClass="alert-info"></asp:Label>
                <br />
                <br />
                <!--Course Feedback-->
                <asp:Label ID="displayCourseFeedback" runat="server" Text="Course Feedback: " CssClass="alert-primary"></asp:Label>
                <br />
                <br />
                <!--Professor Feedback-->
                <asp:Label ID="displayProfessorFeedback" runat="server" Text="Professor Feedback: " CssClass="alert-primary"></asp:Label>
                <br />
                <br />
                <!--Course grade-->
                <asp:Label ID="displayCourseScore" runat="server" Text="Course Results: " CssClass="alert-secondary"></asp:Label>
                <br />
                <br />
                <!--Professor grade-->
                <asp:Label ID="displayProfessorScore" runat="server" Text="Professor Results: " CssClass="alert-success"></asp:Label>
                <br />
                <br />
                <!--Error message-->
                <asp:Label ID="displayError" runat="server" Text="Error: " CssClass="alert-warning"></asp:Label>
                <%--<br />
            <asp:Label ID="test2" runat="server" Text="Results"></asp:Label>--%>
            </div>
        </form>
    </main>
    <!--Collapsible footer info-->
    <footer id="footer">
        <div class="card">
            <div class="card-header text-center">
                <a id="footerHeader" class="card-link" data-toggle="collapse" href="#collapseOne">Copyright
                </a>
            </div>
            <div id="collapseOne" class="collapse text-center" data-parent="#footer">
                <div class="card-body">
                    <p>&copy; Drew Watson <a href="mailto:dru.w@temple.edu">Dru</a></p>
                </div>
            </div>
        </div>
    </footer>
</body>
</html>
