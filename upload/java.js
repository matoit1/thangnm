
function check_login(e)
{
  var acc = document.getElementById('taikhoan').value;
    var pass = document.getElementById('matkhau').value;
    var taikhoan = "dinhtuanlong";
    var matkhau = "dinhtuanlong"; 
	if(acc == "")
	{
        alert("Tài khoản còn trống");
    }else if(acc.length < 6)
	{
        alert("tài khoản ít nhất 6 kí tự");
    }else if(pass == "")
	{
        alert("mật khẩu còn trống");
    }else if(pass.length < 6)
	{
        alert("mật khẩu ít nhất 6 kí tự");
    }else{
        if(acc != taikhoan || pass != matkhau)
		{
            alert("tài khoản hoặc mật khẩu không đúng");
        }else
		{
            return true;
        }
    }
}
function check()
{
    var email = document.getElementById('email').value;
    var re = /^(\w+)@(\w+).(\w{3,4})$/;
    if(re.test(email))
	{ alert("email đúng định dạng");
    }else
	{ alert("email sai định dạng");
    }
}
