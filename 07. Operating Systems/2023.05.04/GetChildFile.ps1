function Get-FilesInDirectory($path) {
    Get-ChildItem $path -File
}

Get-FilesInDirectory "C:\Users\Username\Documents"