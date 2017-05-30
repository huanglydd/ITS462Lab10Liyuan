<?php ini_set('display_errors', '1'); ?>
<?PHP
  ini_set("error_reporting","E_ALL & ~E_NOTICE");
  session_start();// Start Session
  if(!$_SESSION['name']){
      echo "<script language='javascript'>alert('Sorry, you are not logged in');history.back();</script>";
  }
?>

<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<link href="css/login.css" type="text/css" rel="stylesheet">
<script type="text/javascript" src="js/UserProfile.js"></script>
<title>User Profile Page</title>
</head>
  <body>
    <h1>Current User</h1>
    <h2>
    <?PHP
	echo $_SESSION['name'];
    ?>
    </h2>
    <a href="logout.php">Logout</a>
    </r>
    <form name="login" action="php/edit.php" method="post" onsubmit="return check()">
    <table border="1" cellspacing="0" cellpadding="0" id="userList" align="center">
    
<?php
  

  include('connect.php');
  $sql = "select * from user where username = '" + $_SESSION['name'] + "'";
  $result = mysqli_query($con,$sql);
  $userList = '';
  while($rs = mysqli_fetch_array($con,$result)){
        $userList[] = $rs;
    }
          // Iterate the user data
        foreach ($userList as $user){
          echo "
             <tr align=\"center\">
              <td>Username</td><td> <input name=\"name\" id=\"name\" placeholder=\"".$user['username']."\" type=\"text\" required=\"required\" maxlength=\"16\"></td>
             </tr>
             <tr align=\"center\">
              <td>id</td><td><input name=\"id\" id=\"id\" placeholder=\"".$user['id']."\" type=\"text\" required=\"required\" maxlength=\"16\"></td><td><button color=\"blue\" onclick=\"\">Edit</button></td><td><button color=\"red\" onclick=\"\" >Delete</td>
             </tr>
             <tr align=\"center\"> 
              <td>Full Name</td><td><input name=\"fullname\" id=\"fullname\" placeholder=\"".$user['fullname']."\" type=\"text\" required=\"required\" maxlength=\"20\"></td><td><button color=\"blue\" onclick=\"\">Edit</button></td><td><button color=\"red\" onclick=\"\" >Delete</td>
             </tr>
             <tr align=\"center\"> 
              <td>Gender(Type \"Male\" or \"Female\")</td><td><input name=\"gender\" id=\"gender\" placeholder=\"".$user['gender']."\" type=\"text\" required=\"required\" maxlength=\"6\"></td><td><button color=\"blue\" onclick=\"\">Edit</button></td><td><button color=\"red\" onclick=\"\" >Delete</td>
             </tr>
             <tr align=\"center\">
              <td>Birthday</td><td><input name=\"birthday\" id=\"birthday\" placeholder=\"".$user['birthday']."\" required=\"required\" maxlength=\"10\"></td><td><button color=\"blue\" onclick=\"\">Edit</button></td><td><button color=\"red\" onclick=\"\" >Delete</td>
             </tr>
             <tr align=\"right\">
             <input value=\"Save Changes\" style=\"width:100%;\" type=\"submit\" name=\"submit\">
             <input value=\"Reset All\" style=\"width:100%;\" type=\"reset\" name=\"reset\">
             </tr>
          ";
        }
mysqli_clsoe($con);
?>
  </table>
  </form>
  </body>
</html>