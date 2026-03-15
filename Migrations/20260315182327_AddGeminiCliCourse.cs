using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CodeKurs.Web.Migrations
{
    /// <inheritdoc />
    public partial class AddGeminiCliCourse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "Description", "Language", "Order", "Title" },
                values: new object[,]
                {
                    { 156, "<p>Lifecycle und Sub-Agenten für komplexe Aufgaben.</p><p>In dieser Lektion lernst du fortgeschrittene Workflows und den Einsatz von Sub-Agenten kennen.</p>\n", "geminicli", 3, "Fortgeschrittene Workflows" },
                    { 157, "<p>Ein Einstieg in die Welt der Gemini CLI und Agenten-Architektur.</p><p>In dieser Lektion lernst du die Grundlagen der Gemini CLI kennen.</p>\n", "geminicli", 1, "Gemini CLI Grundlagen" },
                    { 158, "<p>Effizientes Arbeiten mit dem Dateisystem durch chirurgische Edits.</p><p>In dieser Lektion erfährst du, wie du effizient mit dem Dateisystem arbeitest.</p>\n", "geminicli", 2, "Datei-Operationen" }
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "ChoicesJson", "CorrectAnswer", "Description", "ExpectedOutput", "InitialCode", "Language", "LessonId", "Order", "PlaceholderDependency", "RequiredKeywords", "Solution", "TestCode", "Title", "Type" },
                values: new object[,]
                {
                    { 1190, null, null, "Deep Theory: Der Workflow der Gemini CLI ist in drei Phasen unterteilt: 1. **Research**: Systematische Analyse des Codes und Validierung von Annahmen (z.B. durch `grep_search` und `read_file`). 2. **Strategy**: Entwurf eines Plans basierend auf den Erkenntnissen. 3. **Execution**: Durchführung der Änderungen in iterativen Plan-Act-Validate-Schritten. Jede Änderung wird durch Tests oder manuelle Prüfung validiert.", "", "", "geminicli", 156, 1, null, null, null, null, "Der Research-Strategy-Execution Lifecycle", 0 },
                    { 1191, null, null, "Nutze den `codebase_investigator`, um die Datenbank-Struktur des Projekts zu analysieren.", "", "", "geminicli", 156, 2, null, "codebase_investigator,objective,DB-Struktur", "codebase_investigator objective=\"Analysiere DB-Struktur\"", null, "Codebase Investigation", 1 },
                    { 1192, null, null, "Vervollständige den Befehl, um den Skill-Creator zu aktivieren: `activate_skill name=\"_____\"`", "", "activate_skill name=\"_____\"", "geminicli", 156, 3, null, "activate_skill,name,skill-creator", "activate_skill name=\"skill-creator\"", null, "Skill-Creator aktivieren", 1 },
                    { 1193, null, null, "Deep Theory: Gemini CLI basiert auf einer Agenten-Architektur, bei der ein Large Language Model (LLM) nicht nur Texte generiert, sondern aktiv Tools aufruft. Der Prozess folgt dem Schema: Research (Informationsbeschaffung), Strategy (Planung) und Execution (Durchführung). Dabei kommuniziert das LLM über strukturierte Tool-Calls mit dem System, um z.B. Dateien zu lesen, zu bearbeiten oder Befehle auszuführen.", "", "", "geminicli", 157, 1, null, null, null, null, "Agenten-Architektur und Tool-Use", 0 },
                    { 1194, null, null, "Gib den Befehl `/help` ein, um die verfügbaren Befehle und die Dokumentation der Gemini CLI anzuzeigen.", "", "", "geminicli", 157, 2, null, "/help", "/help", null, "Den Hilfe-Befehl aufrufen", 1 },
                    { 1195, null, null, "Vervollständige den Aufruf, um die Version der Gemini CLI abzufragen: `gemini-cli --_____`", "", "gemini-cli --_____", "geminicli", 157, 3, null, "version", "gemini-cli --version", null, "Version abfragen", 1 },
                    { 1196, null, null, "Deep Theory: Bei chirurgischen Edits (Surgical Updates) werden nur gezielte Teile einer Datei verändert, anstatt die gesamte Datei neu zu schreiben (Full Writes). Dies spart Kontext-Tokens und minimiert das Risiko von unbeabsichtigten Änderungen in nicht betroffenen Bereichen. Die Gemini CLI bevorzugt chirurgische Edits mittels Tools wie `replace`, um Präzision und Effizienz zu gewährleisten.", "", "", "geminicli", 158, 1, null, null, null, null, "Chirurgische Edits vs. Full Writes", 0 },
                    { 1197, null, null, "Nutze das Tool `grep_search`, um nach allen Vorkommen des Musters \"TODO\" im gesamten Projekt zu suchen.", "", "", "geminicli", 158, 2, null, "grep_search,pattern,TODO", "grep_search pattern=\"TODO\"", null, "Suche nach TODOs", 1 },
                    { 1198, null, null, "Vervollständige den Befehl, um den Inhalt der Datei `Program.cs` zu lesen: `read_file file_path=\"_____\"`", "", "read_file file_path=\"_____\"", "geminicli", 158, 3, null, "read_file,file_path,Program.cs", "read_file file_path=\"Program.cs\"", null, "Datei lesen", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1190);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1191);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1192);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1193);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1194);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1195);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1196);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1197);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1198);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 158);
        }
    }
}
