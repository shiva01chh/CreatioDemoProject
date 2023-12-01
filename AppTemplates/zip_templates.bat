dir

%cls
%cd ..

FOR /f "delims=" %%G in (templates.txt) DO (
	del %%G.zip
	md %%AppCode%%
	xcopy /e %%G\* %%AppCode%%
	"..\..\..\..\..\Bin\Debug\Terrasoft.Tools.WorkspaceConsole.exe" -operation=ZipDirectory -sourcePath=%%AppCode%% -autoExit=1
	tar -a -c -f %%G.zip %%AppCode%%.gz
	del %%AppCode%%.gz
	rd /s /q %%AppCode%%
)

%cd cmd