<?php
    session_start();
    if(!isset($_SESSION['giohang'])) $_SESSION['giohang']=[];
    //làm rỗng giỏ hàng
    if(isset($_GET['delcart'])&&($_GET['delcart']==1)) unset($_SESSION['giohang']);
    //xóa sp trong giỏ hàng
    if(isset($_GET['delid'])&&($_GET['delid']>=0)){
       array_splice($_SESSION['giohang'],$_GET['delid'],1);
    }
    //lấy dữ liệu từ form
    if(isset($_POST['addcart'])&&($_POST['addcart'])){
        $hinh=$_POST['hinh'];
        $tensp=$_POST['tensp'];
        $gia=$_POST['gia'];
        $soluong=$_POST['soluong'];

        //kiem tra sp co trong gio hang hay khong?

        $fl=0; //kiem tra sp co trung trong gio hang khong?

        for ($i=0; $i < sizeof($_SESSION['giohang']); $i++) { 
            
            if($_SESSION['giohang'][$i][1]==$tensp){
                $fl=1;
                $soluongnew=$soluong+$_SESSION['giohang'][$i][3];
                $_SESSION['giohang'][$i][3]=$soluongnew;
                break;

            }
            
        }
        //neu khong trung sp trong gio hang thi them moi
        if($fl==0){
            //them moi sp vao gio hang
            $sp=[$hinh,$tensp,$gia,$soluong];
            $_SESSION['giohang'][]=$sp;
        }

       // var_dump($_SESSION['giohang']);
    }

    function showgiohang(){
        if(isset($_SESSION['giohang'])&&(is_array($_SESSION['giohang']))){
            if(sizeof($_SESSION['giohang'])>0){
                $tong=0;
                for ($i=0; $i < sizeof($_SESSION['giohang']); $i++) { 
                    $tt=$_SESSION['giohang'][$i][2] * $_SESSION['giohang'][$i][3];
                    $tong+=$tt;
                    echo '<tr>
                            <td>'.($i+1).'</td>
                            <td><img src="images/'.$_SESSION['giohang'][$i][0].'" alt=""></td>
                            <td>'.$_SESSION['giohang'][$i][1].'</td>
                            <td>'.$_SESSION['giohang'][$i][2].'</td>
                            <td>'.$_SESSION['giohang'][$i][3].'</td>
                            <td>
                                <div>'.$tt.'</div>
                            </td>
                            <td>
                                <a href="cart.php?delid='.$i.'">Xóa</a>
                            </td>
                        </tr>';
                }
                echo '<tr>
                        <th colspan="5">Tổng đơn hàng</th>
                        <th>
                            <div>'.$tong.'</div>
                        </th>
    
                    </tr>';
            }else{
                echo "Giỏ hàng rỗng!";
            }    
        }
    }
    


?>
<!DOCTYPE html>
<html>
<head>
	<title>Web bán hàng</title>
    <link rel='stylesheet' href='https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css'>
    <link rel="stylesheet" href="giaodien.css">
	<link rel="stylesheet" href="menu.css">
    <link rel="stylesheet" href="cart.css">
    <link rel="stylesheet" href="products.css">
</head>
<body>
    <div id="wrapper">
        <header>
	         <nav class="container">
                <div class="logo-main-menu">
                <a href="" id="logo">
                    <img src="./images/logo1.png" alt="ALTTHSHOP" width="200px">
                </a>
                <ul id="main-menu">
                    <li><a href=""> Black Rouge</a></li>
                    <li><a href=""> 3ce</a></li>
                    <li><a href=""> Gucci</a></li>
                    <li><a href=""> Dior</a></li>
                    <li><a href=""> Srum</a></li>
                </ul>
                </div>
                <div class="main-menu-right">
                <ul id="main-menu-right1">
                    <li><input type="search" name="tim" id="search" placeholder="Tìm kiếm sản phẩm..."></li>
                    <li><button type="submit" name="timkiem">Search</button></li>
                </ul>
                <ul id="main-menu-right2">
                    <li><a href="">Đăng Nhập</a></li>
                    <li><a href="">Đăng Kí</a></li>
                </ul>
                </div>
             </nav>
        </header>
        <div class="row mb ">
            <div class="boxtrai mr" id="bill">
                <div class="row" >
                    <h1>THÔNG TIN NHẬN HÀNG</h1>
                    <table class="thongtinnhanhang">
                        <tr>
                            <td width="20%">Họ tên</td>
                            <td><input type="text" name="hoten" required></td>
                        </tr>
                        <tr>
                            <td>Địa chỉ</td>
                            <td><input type="text" name="diachi" required></td>
                        </tr>
                        <tr>
                            <td>Điện thoại</td>
                            <td><input type="text" name="dienthoai" required></td>
                        </tr>
                        <tr>
                            <td>Email</td>
                            <td><input type="text" name="email" required></td>
                        </tr>
                    </table>
                </div>
                <div class="row mb">
                    <h1>GIỎ HÀNG</h1>
                    <div class="cart-tt">
                        <ul>
                            <li>STT</li>
                            <li>HÌNH</li>
                            <li>TÊN SẢN PHẨM</li>
                            <li>ĐƠN GIÁ</li>
                            <li>SỐ LƯỢNG</li>
                            <li>THÀNH TIEN</li>
                            <li>XÓA</li>
                        </ul>
                        <?php showgiohang(); ?>
                    </div>
                    
                </div>
                <div class="row mb">
                    <input type="submit" value="Đồng Ý Đặt Hàng" name="dongydathang">
                    <a href="cart.php?delcart=1"><input type="button" value="XÓA GIỎ HÀNG"></a>
                    <a href="menu.php"><input type="button" value="TIẾP TỤC ĐẶT HÀNG"></a>
                </div>
            </div>
            <footer>
                <div>
                    <h3>Dịch vụ khách hàng</h3>
                    <ul>
                        <li><a href="https://www.google.com/">Hỏi đáp-FAQs</a></li>
                        <li><a href="https://www.google.com/">Chính sách đổi trả</a></li>
                        <li><a href="https://www.google.com/">Chính sách giao hàng</a></li>
                    </ul>
                </div>
                <div>
                    <h3>Địa chỉ liên hệ</h3>
                    <ul>
            <li><a href="tel:036-999-9999">Điện thoại: <span>036-999-9999</span></a></li>
                        <li><a href = "mailto: 6aesnn@duck.com">Email: <span>altth@gmail.com</span></a></li>
                        <li>Số đăng ký kinh doanh: <span>0368989898</span></li>
                        <li>Địa chỉ: Trường Đại Học Quy Nhơn, TP Quy Nhơn, Tỉnh Bình Định</li>
                    </ul>
                </div>
                <div>
                    <h3>Tuyển dụng</h3>
                    <ul>
                        <li><a href="https://www.google.com/">Thông tin tuyển dụng</a></li>
                        <li><a href="https://www.google.com/">Chính sách đãi ngộ</a></li>
                    </ul>
                </div>
                <div>
                    <h3>Về chúng tôi</h3>
                    <ul>
                        <li><a href="https://www.google.com/">Giới thiệu</a></li>
                        <li><a href="https://www.google.com/">Blogs</a></li>
                        <li><a href="https://www.google.com/">Kế hoạch tương lai</a></li>
                    </ul>
                </div>
                <div>
                    <h3>Mạng xã hội</h3>
                    <ul>
                        <li>
                            <a href="https://www.facebook.com/"><img src="./images/facebook.png" alt="facebook"></a>
                            <a href="https://www.instagram.com/"><img src="./images/instagram.png" alt="instagram"></a>
                            <a href="https://www.youtube.com/"><img src="./images/youtube.png" alt="youtube"></a>
                        </li>
                    </ul>
                </div>
        </footer>
    </div>
</body>