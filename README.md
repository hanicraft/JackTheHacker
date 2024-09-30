# JackTheHacker
a open source bruteforce tool with config support

this tool is an spritual successor to InstaBrute but unlike InstaBrute, you can use this tool to bruteforce any website by creating configs

Note : the author of this software is not responsible for your actions and usage of software, we dont take any responsiblity

# Config Creation
to create configs you need to understand its format. heres an explaintion of config format for instagram

```ini
[target]
url = https://www.instagram.com/accounts/login/

[headers]
userheader = username
passheader = password

[bruteforce]
timeout = 5
attempts = 10
delay = 1
```
"url" : login page of website you want to bruteforce

"userheader" = username or email header of login page(for example if the website uses this login format "example.com/login?user=testusername&pass=testpassword" the userheader should be "user") 

"passheader" = is the same as "userheader"

and the rest are settings for bruteforcer

# Issues

if you have any suggestion or want me to add any features feel free to open an issue, but please dont open issue asking me or others to hack someone for you

# License

this project is licensed under MIT License, but the project logo is licensed under under CC-BY-NC-SA 4 

# Contribution

all contribution are welcome (:
