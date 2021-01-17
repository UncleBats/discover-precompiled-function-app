# discover-precompiled-function-app
Repository for demo purposes used in blog https://www.ericksegaar.com/2021/01/19/discover-precompiled-function-apps/

Yes, you can use precompiled azure functions in other applications. To do so add <FunctionsInDependencies>true</FunctionsInDependencies> to your *.csproj. Make sure you use the shared assembly otherwise the optimizer will block it from discovery.  Could use the configuration method shown in the example. If you want to see the full working demo you can check out this repository.
