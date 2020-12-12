# BypassAddUser
绕过杀软添加用户

## 感谢 AnonySec 大佬的宝贵建议

已测Win2008,Win2012,Win10都没问题

**注意密码复杂性！！！**

**注意密码复杂性！！！**

**注意密码复杂性！！！**

### 2020.12.12 更新：重构代码，加入添加rdp组功能

```
Usage: BypassAddUser.exe -u username -p password -g groups    添加用户
       BypassAddUser.exe -u username -p password -g groups -rdp    添加用户，并添加到rdp组
       BypassAddUser.exe -c UserName NewPassword    更改用户密码
       BypassAddUser.exe -d UserName    删除用户
Example: BypassAddUser.exe -u test -p testpass -g administrators
         BypassAddUser.exe -u test -p testpass -g administrators -rdp
         BypassAddUser.exe -c test NewtestPass
         BypassAddUser.exe -d test
```

### 上传到目标机器注意目标机器存在的`.net`版本，win2008推荐3.5版本，win2012推荐4.0版本

可使用微软社区的工具来检查目标机器存在的`.net`版本

微软地址：   https://docs.microsoft.com/zh-cn/dotnet/framework/migration-guide/how-to-determine-which-versions-are-installed

github地址：  https://github.com/jmalarcon/DotNetVersions

![images](https://github.com/TryA9ain/BypassAddUser_new/blob/master/Snipaste_2020-12-12_13-04-30.jpg)

![images](https://github.com/TryA9ain/BypassAddUser_new/blob/master/Snipaste_2020-12-12_13-04-43.jpg)



### 添加用户，并加入rdp组
![images](https://github.com/TryA9ain/BypassAddUser_new/blob/master/Snipaste_2020-12-12_12-32-57.jpg)

### cs内存加载
![images](https://github.com/TryA9ain/BypassAddUser_new/blob/master/Snipaste_2020-12-12_12-43-26.jpg)

![images](https://github.com/TryA9ain/BypassAddUser_new/blob/master/Snipaste_2020-12-12_12-43-40.jpg)

![images](https://github.com/TryA9ain/BypassAddUser_new/blob/master/Snipaste_2020-12-12_12-43-48.jpg)

## 参考链接
https://docs.microsoft.com/zh-cn/troubleshoot/dotnet/csharp/add-user-local-system

## 问题建议

欢迎大佬们提出问题或建议
