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
