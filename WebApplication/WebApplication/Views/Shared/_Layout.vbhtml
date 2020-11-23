<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>@ViewData("Title")</title>

    @*<link href="@Url.Content("./Content/bootstrap.min.css")" rel="stylesheet" type="text/css" />*@
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/css/bootstrap.min.css" integrity="sha384-TX8t27EcRE3e/ihU7zmQxVncDAy5uIKz4rEkgIXeMed4M0jlfIDPvg6uqKI2xXr2" crossorigin="anonymous">


</head>
<body>
    <nav class="navbar navbar-expand-md bg-info navbar-dark">
        <a href="#" class="nav-brand">
            <img src="./Content/GGplay.png" alt="logo">
        </a>
        <ul class="navbar-nav px-4">
            <li class="nav-item active">
                <a class="nav-link" @Html.ActionLink("Link 1", "Link", "Example")</a>         
            </li>
            <li class="nav-item">
                <a class="nav-link" href="#">Link 2</a>
            </li>
            <li class="nav-item">
                <a class="nav-link disabled" href="#">Link 3</a>
            </li>
        </ul>
    </nav>

    <div class="jumbotron jumbotron-fluid bg-info text-white text-center">
        <div class="container">
            <h1 class="display-1">Welcome to the Find Info</h1>
            <p class="lead">Find any info in here...</p>
        </div>
    </div>

    <div class="container">
        <!-- cards -->
        <div class="row justify-content-center">
            <div class="col-md-10 bg-secondary">
                <h2 class="display-6 text-center">037 - SỞ GD&ĐT TPHCM</h2>
                <h1 class="display-5 text-center">TRA CỨU ĐIỂM THI TỐT NGHIỆP THPT 2020</h1>
                <p class="display-5 text-left px-5">Thí sinh nhập số báo danh và mã xác nhận vào các ô dưới đây</p>
                <div class="form-group row px-5">
                    <label for="SBD" class="col-sm-2 col-form-label">Số báo danh</label>
                    <div class="col-md-8">
                        <input type="password" class="form-control" id="SBD" placeholder="Nhập số báo danh">
                    </div>
                </div>
                <div class="form-group row px-5">
                    <label for="MXN" class="col-sm-2 col-form-label">Mã xác nhận</label>
                    <div class="col-md-5">
                        <input type="password" class="form-control" id="MXN" placeholder="Nhập mã xác nhận">
                    </div>
                    <img class="img-fluid" src="http://diembinhdinh2020.vnedu.vn/TraCuu/GetCaptcha?time=1605243896488&choose=1" alt="MXN" style="height: 38px;">
                </div>
                <div class="text-center" style="margin-bottom: 10px;">
                    <button type="button" class="btn btn-info text-center ">Tra cứu</button>
                </div>
                <div>
                    @RenderBody()
                </div>


            </div>
        </div>
    </div>

    <h2 class="display-4 text-center py-3 text-primary">Meet the speakers</h2>
    <footer class="page-footer font-small bg-info py-3">
        <div class="footer-copyright text-center">© 2020 Copyright: 037 - SỞ GD&ĐT TPHCM</div>
    </footer>
    
</body>
</html>
