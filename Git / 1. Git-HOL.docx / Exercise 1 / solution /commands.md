# Exercise 1 Solution

## Step 1 Verify Git Installation

```bash
git --version
```

Expected Output

```
git version 2.xx.x.windows.x
```

---

## Step 2 Configure Username

```bash
git config --global user.name "Your Name"
```

Example

```bash
git config --global user.name "John Doe"
```

---

## Step 3 Configure Email

```bash
git config --global user.email "yourmail@gmail.com"
```

Example

```bash
git config --global user.email "john@gmail.com"
```

---

## Step 4 Verify Configuration

```bash
git config --global --list
```

Expected Output

```
user.name=John Doe
user.email=john@gmail.com
```

---

## Step 5 Verify Notepad++

```bash
notepad++
```

If command is not recognized, add Notepad++ installation folder to Windows PATH.

---

## Step 6 Create Alias

```bash
git config --global alias.editor "!notepad++"
```

---

## Step 7 Configure Default Editor

```bash
git config --global core.editor "notepad++"
```

---

## Step 8 Verify Default Editor

```bash
git config --global -e
```

This opens the Git global configuration file in Notepad++.

---

## Step 9 Create Project Folder

```bash
mkdir GitDemo
```

---

## Step 10 Enter Project

```bash
cd GitDemo
```

---

## Step 11 Initialize Repository

```bash
git init
```

Expected Output

```
Initialized empty Git repository...
```

---

## Step 12 View Hidden Files

```bash
ls -la
```

You should see

```
.git
```

---

## Step 13 Create File

```bash
echo "Welcome to Git" > welcome.txt
```

---

## Step 14 Verify File

```bash
ls
```

---

## Step 15 View File Contents

```bash
cat welcome.txt
```

Expected Output

```
Welcome to Git
```

---

## Step 16 Check Repository Status

```bash
git status
```

Expected Output

```
Untracked files:
welcome.txt
```

---

## Step 17 Add File

```bash
git add welcome.txt
```

or

```bash
git add .
```

---

## Step 18 Commit File

```bash
git commit
```

The configured editor opens.

Enter

```
Initial Commit

Created welcome.txt
```

Save and close the editor.

Alternatively

```bash
git commit -m "Initial Commit"
```

---

## Step 19 Verify Status

```bash
git status
```

Expected Output

```
nothing to commit, working tree clean
```

---

## Step 20 Add Remote Repository

```bash
git remote add origin https://github.com/<username>/GitDemo.git
```

Example

```bash
git remote add origin https://github.com/john/GitDemo.git
```

---

## Step 21 Pull Remote Repository

```bash
git pull origin master
```

For newer Git versions

```bash
git pull origin main
```

---

## Step 22 Push Repository

```bash
git push -u origin master
```

or

```bash
git push -u origin main
```

---

## Verify Remote

```bash
git remote -v
```

Expected Output

```
origin https://github.com/username/GitDemo.git
```
