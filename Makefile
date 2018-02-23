run:
	dotnet run --project $(project)

create:
	mkdir -p $(project)
	cd $(shell pwd)/$(project) && dotnet new $(kind)