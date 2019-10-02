dotnet pack -c Release /p:TargetFrameworks=netstandard1.3 /p:PackageVersion=2.5.9 ./src/Elasticsearch.Net -o ./artifacts
dotnet pack -c Release /p:TargetFrameworks=netstandard1.3 /p:PackageVersion=2.5.9 ./src/Nest -o ./artifacts
