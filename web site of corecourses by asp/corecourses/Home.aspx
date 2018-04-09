<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="corecourses.WebForm2" %>

<!DOCTYPE html>


<html  dir="rtl">
    
    <head> 
    <!-- CSS -->
    <link rel="stylesheet" href="./كورسات_files/bootstrap.css">
    <link rel="stylesheet" href="./كورسات_files/bootstrap.rtl.css">
    <link rel="stylesheet" href="./كورسات_files/font-awesome.min.css">
    <link rel="stylesheet" href="./كورسات_files/style.css">
    <link rel="stylesheet" href="./كورسات_files/rtl-xtra.css">
    <link rel="shortcut icon" type="image/x-icon" href="coursat.png">
        <title>CoreCourses</title>
    </head>

    <body>

    <!--Navbar-->
    <nav class="navbar navbar-inverse navbar-fixed-top">
      <div class="container">
        <div class="navbar-header">
        <a class="navbar-brand" href=""><img src="logo.png" height="75px" alt="Co"></a>
    </div>
<!-- Navbar Right -->

<div class="collapse navbar-collapse js-navbar-collapse" id="ournavbar">

<ul class="nav navbar-nav navbar-left">
              <li>    <img src="login.PNG" height="80px"/></li>
            <li><a href="Register.aspx"> Register</a></li>
            <li><img src="reg.PNG"  height="80px"/></li>
            <li><a href="Login.aspx" > Login</a></li>

            
 </ul>
</div>
</div>
</nav>

<!-- Search -->
<section class="head text-center">
    <div class="bg" style="background-image:url(logoo.png);">
    <div class="container">
        <h2 style="font-family: Bell MT ; font:bold; color:#FF8C00;">?what do you want to learn</h2>
        <div class="row" style="margin-top:40px;margin-bottom:40px; width:650px; margin-right:250px;">
            <div >
                <div id="search-input">
                    <form id="form1" runat="server" autocomplete="off">
                        <asp:TextBox ID="TextBox1" runat="server" ForeColor="Black" placeholder="Enter cource name        Ex : PHP , Java , C#, Photoshop" Width="500px"></asp:TextBox>
                        <asp:Button ID="Button1" runat="server" Text="Search" />
                    </form>
            </div>
            </div>
        </div>       
        </div>
    </div>
</section>
<!-- End Search -->


<!-- Categories -->
<section class="categories text-center">
    <div class="container">
        <h2 class="categories_title">Course Classifications</h2>
        <hr>

    <div class="row">
        

        <div class="col-xs-12 col-sm-6 col-lg-3">
            <div class="category_box">
                <div class="icon">
                    <div class="image"><i class="fa fa-code"></i></div>
                    <div class="info">
                        <h3 class="title"><a href="">Programming Languages</a></h3>
                        <p>Courses and tutorials in different programming languages such as web languages, phone application programming languages, and desktop application programming languages </p>
                        <div class="more">
                            <a href=" " title="Display course in this category"> Display Materials</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="col-xs-12 col-sm-6 col-lg-3">
            <div class="category_box">
                <div class="icon">
                    <div class="image"><i class="fa fa-paint-brush"></i></div>
                    <div class="info">
                        <h3 class="title"><a href=" ">Design</a></h3>
                        <p>Courses in various design programs and areas such as print design, 3D shapes, advertising design ... etc </p>
                        <div class="more">
                            <a href=" " title="Display course in this category"> Display Materials</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="col-xs-12 col-sm-6 col-lg-3">
            <div class="category_box">
                <div class="icon">
                    <div class="image"><i class="fa fa-globe"></i></div>
                    <div class="info">
                        <h3 class="title"><a href=" ">Languages</a></h3>
                        <p>Courses in different languages such as Arabic, English, Turkish and other languages and explanations of their rules, pronunciation, reading and writing</p>
                        <div class="more">
                           <a href=" " title="Display course in this category"> Display Materials</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="col-xs-12 col-sm-6 col-lg-3">
            <div class="category_box">
                <div class="icon">
                    <div class="image"><i class="fa fa-code-fork"></i></div>
                    <div class="info">
                        <h3 class="title"><a href=" ">Computer Networks</a></h3>
                        <p>
Computer networks are an essential necessity in today's fast-paced world. Networks vary according to their size to three main types: LAN, WAN ... </p>
                        <div class="more">
                           <a href=" " title="Display course in this category"> Display Materials</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        </div>
        </div>
         
</section>

<!-- End Categories -->

<!-- Ads -->
<script data-cfasync="false" type="text/javascript" src="./كورسات_files/banners"></script><script type="text/javascript" src="./كورسات_files/banners(1)"></script><script data-cfasync="false" id="rh_tag_BOUNCE_159012_279909_2" type="text/javascript" src="./كورسات_files/bounce-tag_2.52-25.0.js.download"></script><script data-cfasync="false" id="rh_tag_POPUNDER_159012_279909_6" type="text/javascript" src="./كورسات_files/rhpop_2.64-25.2.js.download"></script><iframe id="ztL17b3rL" style="display: none;" src="./كورسات_files/saved_resource.html"></iframe>
<!-- End Ads -->
<!-- Footer -->
<div class="footer text-center">

    <div class="container">

    <ul class="list-unstyled footer-links">
        <li><a href=" ">About CoreCourses</a></li>
        <li><a href=" ">Contact us</a></li>
    </ul>

    <div>
        <ul class="list-unstyled footer-social">
            <li><a href="https://twitter.com/CoreCourse">twitter  </a></li>
            <li><a href="https://www.facebook.com/CoreCourse"> facebook  </a></li>
        </ul>
    </div>

    
    
</div>

<div class="copyright text-center">
© 2017 <span><a href=" ">Core Courses</a></span> 
</div>
    
</div>
<!-- End Footer -->
</body></html>