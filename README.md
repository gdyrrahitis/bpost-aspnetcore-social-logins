# ASP.NET Core 2.0 user authentication with social logins
https://wp.me/p7uERY-9V

## Facebook
```
services.AddFacebook(options => {
    options.AppId = "";
    options.AppSecret = "";
});
```
## Twitter
```
services..AddTwitter(options => {
    options.ConsumerKey = "";
    options.ConsumerSecret = "";
})
```
## Github
```
services.AddGitHub(options => {
    options.ClientId = "";
    options.ClientSecret = "";
})
```
