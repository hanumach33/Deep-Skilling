# Exercise 1 Solution

## Step 1 Navigate to Repository

```bash
cd GitDemo
```

---

## Step 2 Create Log Folder

```bash
mkdir logs
```

---

## Step 3 Create Log Files

```bash
touch error.log
touch logs/application.log
```

If `touch` is unavailable on Windows Git Bash, use:

```bash
echo. > error.log
echo. > logs/application.log
```

---

## Step 4 Create .gitignore File

```bash
touch .gitignore
```

or

```bash
echo. > .gitignore
```

---

## Step 5 Open .gitignore

```bash
notepad++ .gitignore
```

---

## Step 6 Add Ignore Rules

```gitignore
*.log
logs/
```

### Explanation

- `*.log` ignores every file ending with `.log`.
- `logs/` ignores the entire `logs` directory and all of its contents.

---

## Step 7 Save the File

Save and close `.gitignore`.

---

## Step 8 Check Repository Status

```bash
git status
```

Expected Output

```
Untracked files:
.gitignore

nothing about

error.log

or

logs/
```

Git ignores all `.log` files and the `logs` folder because of the rules in `.gitignore`.

---

## Step 9 Add .gitignore

```bash
git add .gitignore
```

---

## Step 10 Commit

```bash
git commit -m "Added .gitignore"
```

Expected Output

```
1 file changed
create mode 100644 .gitignore
```

---

## Step 11 Verify Status

```bash
git status
```

Expected Output

```
On branch master

nothing to commit, working tree clean
```

---

## Optional Verification

Create another log file:

```bash
touch sample.log
```

Run:

```bash
git status
```

Expected Output

```
sample.log does not appear
```

This confirms that `.gitignore` is working correctly.
