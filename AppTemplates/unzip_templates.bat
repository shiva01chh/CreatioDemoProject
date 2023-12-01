%cls
%cd ..

FOR /f "delims=" %%G in (templates.txt) DO (
	rd /q /s %%G
	tar -xf %%G.zip
	"..\..\..\..\..\Bin\Debug\Terrasoft.Tools.WorkspaceConsole.exe" -operation=UnzipDirectory -sourcePath=%%AppCode%%.gz -autoExit=1
	del %%AppCode%%.gz
	rename %%AppCode%% %%G
)

%cd cmd