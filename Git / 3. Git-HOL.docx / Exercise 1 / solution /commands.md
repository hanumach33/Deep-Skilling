# Exercise 1 Solution

## Step 1 Create a New Branch

```bash
git branch GitNewBranch
```

---

## Step 2 List All Local Branches

```bash
git branch
```

Expected Output

```
* master
  GitNewBranch
```

The `*` symbol indicates the current branch.

---

## Step 3 List Local and Remote Branches

```bash
git branch -a
```

Expected Output

```
* master
  GitNewBranch
  remotes/origin/master
```

---

## Step 4 Switch to the New Branch

```bash
git checkout GitNewBranch
```

or (recommended)

```bash
git switch GitNewBranch
```

---

## Step 5 Create a New File

```bash
echo "This file belongs to GitNewBranch." > branch.txt
```

---

## Step 6 Verify File

```bash
cat branch.txt
```

Expected Output

```
This file belongs to GitNewBranch.
```

---

## Step 7 Check Status

```bash
git status
```

Expected Output

```
Untracked files:
branch.txt
```

---

## Step 8 Stage the File

```bash
git add branch.txt
```

---

## Step 9 Commit the Changes

```bash
git commit -m "Added branch.txt in GitNewBranch"
```

Expected Output

```
1 file changed
create mode 100644 branch.txt
```

---

## Step 10 Verify Repository Status

```bash
git status
```

Expected Output

```
nothing to commit, working tree clean
```

---

# Merging

## Step 11 Switch Back to Master

```bash
git checkout master
```

or

```bash
git switch master
```

---

## Step 12 Compare Master and Branch

```bash
git diff master GitNewBranch
```

This displays all command-line differences.

---

## Step 13 Compare Using P4Merge

```bash
git difftool master GitNewBranch
```

If P4Merge is configured as the default diff tool, it opens a graphical comparison window.

---

## Step 14 Merge the Branch

```bash
git merge GitNewBranch
```

Expected Output

```
Updating xxxxxxx..xxxxxxx
Fast-forward
branch.txt
```

---

## Step 15 View Commit History

```bash
git log --oneline --graph --decorate
```

Example Output

```
* abc1234 (HEAD -> master) Added branch.txt in GitNewBranch
* xyz9876 Initial Commit
```

---

## Step 16 Delete the Branch

```bash
git branch -d GitNewBranch
```

Expected Output

```
Deleted branch GitNewBranch
```

---

## Step 17 Verify Remaining Branches

```bash
git branch
```

Expected Output

```
* master
```

---

## Step 18 Final Status

```bash
git status
```

Expected Output

```
On branch master

nothing to commit, working tree clean
```
