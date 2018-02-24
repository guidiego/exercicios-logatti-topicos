run:
	dotnet run --project $(project)

create:
	mkdir -p $(project)
	cd $(shell pwd)/$(project) && dotnet new $(kind) && dotnet add . reference ../../utils/utils.csproj