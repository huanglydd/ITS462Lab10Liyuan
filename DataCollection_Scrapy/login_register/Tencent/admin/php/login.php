<?PHP
  header("Content-Type: text/html; charset=utf8");

  if(!isset($_POST["submit"])){
    exit("非法访问！");
  }//检测是否有submit操作 

  include('connect.php');//链接数据库

  $name = $_POST['name'];//post获得用户名表单值
  $passowrd = MD5($_POST['password']);//post获得用户密码单值,使用MD5加密，不可逆

  if ($name && $passowrd){//如果用户名和密码都不为空
       $sql = "select * from admin where username = '$name' and password='$passowrd'";//检测数据库是否有对应的username和password的sql
       $result = mysql_query($sql);//执行sql
       $rows=mysql_num_rows($result);//返回一个数值
       if($rows){//0 false 1 true
       	  //登录成功
       	  session_start();//启动Session
       	  $_SESSION['name'] = $_POST['name'];
          header("refresh:0;url=sucess.php");//如果成功跳转至sucess.php页面
          exit;
       }else{
        echo "用户名或密码错误，请重新登录！";
        echo "
          <script>
              setTimeout(function(){window.location.href='../login.html';},1000);
          </script>
 
        ";//如果错误使用js 1秒后跳转到登录页面重试;
       }

  }else{//如果用户名或密码有空
        echo "用户名或密码填写不完整，请重新登录！";
        echo "
           <script>
              setTimeout(function(){window.location.href='../login.html';},1000);
           </script>";
            //如果错误使用js 1秒后跳转到登录页面重试;
  }

  mysql_close();//关闭数据库
?>