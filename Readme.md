<p align="center"">
    <h1 align="center">Dirmap</h1>
    <p align="center">
        <img src="https://img.shields.io/badge/made%20with-C%23-blue?style=plastic">
        <img src="https://img.shields.io/badge/license-MIT-green?style=plastic">
        <img src="https://img.shields.io/badge/open%20source-red?style=plastic">
        <img src="https://img.shields.io/badge/suggestions-welcome-green?style=plastic">
        <img src="https://img.shields.io/github/last-commit/augus99/dirmap?style=plastic">
        <img src="https://img.shields.io/github/commit-activity/y/augus99/dirmap?style=plastic">
    </p>
</p>

## Description
Basic command line interface (CLI) for displaying a tree containing all files and directories of the specified directory.

## Build
To build the project you will need dotnet installed on your computer, then type the following lines on your preferred terminal
```console
augus99@home:~/Desktop $ git clone https://github.com/augus99/dirmap.git
augus99@home:~/Desktop $ cd dirmap
augus99@home:~/Desktop/dirmap $ dotnet build
```

## Run
To run this project simply run this command
```console
augus99@home:~/Desktop/dirmap $ dotnet run
```

## Options
This application provides 2 optionals arguments

| Option           | Description                 | Default Value |
| ---------------- | --------------------------- | --------- |
| <kbd>-t</kbd> <kbd>--target</kbd> | Set target directory.       | `./` |
| <kbd>-d</kbd> <kbd>--depth</kbd>  | Set tree depth.             | `3` |

## Examples

```console
augus99@home:~/Desktop/dirmap $ dotnet run --target ./bin
augus99@home:~/Desktop/dirmap $ dotnet run --depth 1
augus99@home:~/Desktop/dirmap $ dotnet run --target ./bin --depth 1
```
