// Author: Alexander Sutter
// Date: 11/12/2022
// Latest Update: 

/* FileHandler */

class FileHandler {
    public static void WriteString(string text, string filePath, char writeMode) {
        if (writeMode == 'w') {
            File.WriteAllText(filePath, text);
        } // end if statement
        else if (writeMode == 'a') {
            using StreamWriter file = new(filePath, append: true);
            file.WriteLine(text);
        } // end else if statement
        else {
            Console.WriteLine("Error: WriteMode not passed properly");
        } // end else statement
    } // end WriteString

    public static void WriteString(string[] text, string filePath, char writeMode) {
        foreach (string item in text) {
            if (writeMode == 'w') {
                File.WriteAllText(filePath, item);
                writeMode = 'a';
            } // end if statement
            else if (writeMode == 'a') {
                using StreamWriter file = new(filePath, append: true);
                file.WriteLine(item);
            } // end else if statement
            else {
                Console.WriteLine("Error: WriteMode not passed properly");
            } // end else statement
        } // end foreach item loop
    } // end WriteString

    public static string ReadFile(string filePath) {
        return System.IO.File.ReadAllText(filePath);
    } // end ReadFile

    public static string[] GetContent(string filePath) {
        return System.IO.File.ReadAllLines(filePath);
    } // end GetContent
} // end FileHandler

class Testing {
    public static void Main() {
        string text = "blah";

        string filePath = "C:/Users/testing.txt";

        FileHandler.WriteString(text, filePath, 'a');

        string data = FileHandler.ReadFile(filePath);
        Console.WriteLine(data);

        string[] fileContent = FileHandler.GetContent(filePath);
        foreach (string line in fileContent) {
            Console.WriteLine(line);
        } // end foreach line loop
    } // end Main method
} // end Testing