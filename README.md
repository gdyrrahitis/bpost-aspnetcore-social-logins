# ASP.NET Core 2.0 user authentication with social logins
Related blog post can be found [here](http://codereform.com/blog/post/asp-net-core-2-1-authentication-with-social-logins/)

## Facebook
```
services.AddFacebook(options => {
    options.AppId = "";
    options.AppSecret = "";
});
```
## Twitter
```
services.AddTwitter(options => {
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
