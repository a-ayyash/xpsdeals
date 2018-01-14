## Why application

There were two reasons for building this application:
* a great way to speed up my learning.
* finish the interview exercise.

As for the first reason, when one learns something new, one can't ask for a better way to aqcuire knowledge than labour. Especially if said labour had a purpose and a time frame, then all the better.

As for the second point, yes there is the interview part in it, but there is also the 'finish' part. Which can be easily underrated.

## Why dotnet

Microsoft, the name we like to hate. When I joined ABB I was introduced to a new framework called `dotnet core` and initially I was dismissive. But then when I tried it I fell for it and decided to learn it seriously. So what were my reasons for that jump ?

The following discussion is going to focus on ASP.NET Core which is built using dotnet core but is not the same thing.

The reasons are grouped into two groups Selfish, and Technical. For irony's sake let's start with Technical. 

#### technical
1. Dependency Injection. 
2. Modern web framework conventions (over configurations).
3. Razor templating engine. 
3. Good Community. 
4. Open Source. 
5. Cross Platform. 
6. Visual Studio. 

#### Selfish
1. Visual Studio.
2. No visible XML. 
3. High level, Type Safe, Compiled Language (C#). 

Now don't get me wrong, I have a fair background in dynamic scripting langauges (Ruby, Elixir) and as there is a certain beauty there and all the following points can be made to happen in them. For Selfish reasons I prefer the safety of built in Type Safe, Compiled, Easily tracable/debuggable languages. 

Elixir/Pheonix is next to learn. 

## Lessons Learned:

1. Github private repos can be tricky to deal with. 
2. Heroku buildpacks are awesome. 
3. Travis need to be told about buildpack explicitly
4. Travis needs to use git strategy for custom buildpacks. 

## Improvements to be done.

1. Use stubs and mocks in tests. 
2. Generate a schema for the response to test against. 
3. Refactor REST package classes to a service and inject it. 
4. UI tests.
5. Create a staging environment in heroku. 
6. Caching. (See Below)

## Notes

1. At some point I realize that the code should not exist in a public github repository so I made the move to a private one. That also meant that Travis pro had to be used. Result:
	1. The code is not publicly available. 
	2. git log is shortened, as I started a new repository alltogether after trying to reuse the old one.
2. As this is a learning experience the choice was made not to use the fancy template visual studio generates and started from an empty one, Results:
	1. Did not have time to implement basic functions like (Caching).
	2. Did not work on the gulp/bower pipeline and chose to copy the dist files of bootstrap/jquery as is.





