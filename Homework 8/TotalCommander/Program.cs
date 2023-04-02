using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalCommander
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DirectoryInfo curDir = new DirectoryInfo(Directory.GetCurrentDirectory().ToString());
			string[] command;
			while (true)
			{
				ShowCurDir();
				command = Console.ReadLine().Split(' ');
				if (command[0] == "exit") { break; }
				switch (command[0])
				{
					case "dir": //Получение списка директорий и файлов внутри текущей директории
						Directs();
						break;
					case "cd": //Change directory -изменение текущей директории
						ChangeDir();
						break;
					case "md": //Make directory - создание новой директории
						CreateDir();
						break;
					case "echo": //Создание файла
						CreateFile();
						break;
					case "rd": //Remove dir - удаление папки
						RemoveDir();
						break;
					case "del": //Delete file - удаление файла
						RemoveFile();
						break;
					case "copydir": //Копирование директорий
						CopyDir();
						break;
					case "copy": //Копирование файла
						CopyFile();
						break;
					case "movedir"://Перемещение/переименование директории 
						MoveDir();
						break;
					case "move": //Перещение/переименование файла
						Move();
						break;
					default:
                        Console.WriteLine("Unknown command.");
						break;
                }
			}
			void Move()
			{
				if (command.Length != 3) { Console.WriteLine("Use: move <source_file> <destination_file>"); return; }
				string sourceFile = command[1];
				if (!File.Exists(sourceFile)) { Console.WriteLine($"File {sourceFile} not found"); return; }
				string destinationFile = command[2];
				File.Move(sourceFile, destinationFile);
			}
			void MoveDir()
			{
				if (command.Length != 3) { Console.WriteLine("Use: movedir <source_directory> <destination_directory>"); return; }
				string sourceDirectory = command[1];
				if (!Directory.Exists(sourceDirectory)) { Console.WriteLine($"Directory {sourceDirectory} is not exists!"); return; }
				string destinationDirectory = command[2];
				if (!Directory.Exists(destinationDirectory))
				{
					Directory.CreateDirectory(destinationDirectory);
				}
				Directory.Move(sourceDirectory, destinationDirectory);
			}
			void CopyFile()
			{
				if (command.Length != 3) { Console.WriteLine("Use: copy <source_file> <destination_file>"); return; }
				string sourceFile = command[1];
				if (!File.Exists(sourceFile)) { Console.WriteLine($"File {sourceFile} not found"); return; }
				string destinationFile = command[2];
				if (File.Exists(destinationFile))
				{
					Console.WriteLine($"File {destinationFile} already exists. Overwrite? (Y/N)");
					ConsoleKeyInfo key = Console.ReadKey();
					if (key.KeyChar == 'Y' | key.KeyChar == 'y')
					{
						File.Copy(sourceFile, destinationFile, true);
					}
				}
			}
			void CopyDir()
			{
				if (command.Length != 3) { Console.WriteLine("Use: copydir <source_directory> <destination_directory>"); return; }
				string sourceDirectory = command[1];
				if (!Directory.Exists(sourceDirectory)) { Console.WriteLine($"Directory {sourceDirectory} is not exists!"); return; }
				string destinationDirectory = command[2];
				CopyDirRec(sourceDirectory, destinationDirectory);

			}
			void CopyDirRec(string sourceDirectory, string destinationDirectory)
			{
				if (!Directory.Exists(destinationDirectory))
				{
					Directory.CreateDirectory(destinationDirectory);
				}
				string[] files = Directory.GetFiles(sourceDirectory);
				string[] directories = Directory.GetDirectories(sourceDirectory);
				foreach (string file in files)
				{
					string fileName = Path.GetFileName(file);
					string destinationFilePath = Path.Combine(destinationDirectory, fileName);
					File.Copy(file, destinationFilePath);
				}
				foreach (string directory in directories)
				{
					string directoryName = Path.GetFileName(directory);
					string destinationDirectoryPath = Path.Combine(destinationDirectory, directoryName);
					CopyDirRec(directory, destinationDirectoryPath);
				}

			}
			void RemoveFile()
			{
				string tempPath = curDir + "\\" + command[1];
				if (File.Exists(tempPath)) { File.Delete(tempPath); }
			}
			void RemoveDir()
			{
				string tempPath = curDir + "\\" + command[1];
				if (Directory.Exists(tempPath)) { Directory.Delete(tempPath, true); }
			}
			void CreateFile()
			{
				string tempPath = curDir + "\\" + command[1];
				if (!File.Exists(tempPath)) { File.Create(tempPath); }
				else { Console.WriteLine("Error! File with the same name already exists."); }
			}
			void CreateDir()
			{
				string tempPath = curDir + "\\" + command[1];
				if (!Directory.Exists(tempPath)) { Directory.CreateDirectory(tempPath); }
				else { Console.WriteLine("Error! Directory with the same name already exists."); }
			}
			void Directs()
			{
				DirectoryInfo[] dirs = curDir.GetDirectories();
				foreach (DirectoryInfo dir in dirs)
				{
					Console.WriteLine("<DIR>\t" + dir.Name);
				}
				FileInfo[] files = curDir.GetFiles();
				foreach (FileInfo file in files)
				{
					Console.WriteLine("\t" + file.Name);
				}
			}
			void ChangeDir()
			{
				if (command.Length == 1) { return; }
				if (command[1] == "..")
				{
					DirectoryInfo tempDir = Directory.GetParent(curDir.FullName);
					if (tempDir != null) { curDir = tempDir; }
				}
				else
				{
					if (Directory.Exists(command[1]))
					{
						curDir = new DirectoryInfo(command[1]);
					}
					else if (Directory.Exists(curDir.FullName + "\\" + command[1]))
					{
						curDir = new DirectoryInfo(curDir.FullName + "\\" + command[1]);
					}
					else
					{
						Console.WriteLine("Error! Directory not founded.");
					}
				}
			}

			void ShowCurDir()
			{
				Console.Write(curDir + ">");
			}
		}
	}
}
