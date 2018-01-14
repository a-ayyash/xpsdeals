
[![Build Status](https://travis-ci.org/a-ayyash/xpsdeals.svg?branch=master)](https://travis-ci.org/a-ayyash/xpsdeals)

## Run 

1. Install [dotnet core](https://dotnet.github.io/)
2. Run the following commands:
	1. `dotnet restore`
	2. `dotnet run`


## Test

1. Install [dotnet core](https://dotnet.github.io/)
2. Run the following commands:
	1. `dotnet restore`
	2. `dotnet test`

## Build Pipeline

1. Push to the github repository.
2. Travis CI is notified and a build starts
3. Travis CI runs tests
4. Travis CI Deploys to [heroku](https://xpsdealsfinder.herokuapp.com/)
