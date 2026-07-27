# Optional P4Merge Configuration

Configure P4Merge as the default diff tool.

## Configure Diff Tool

```bash
git config --global diff.tool p4merge
```

## Configure Merge Tool

```bash
git config --global merge.tool p4merge
```

## Verify Configuration

```bash
git config --global --list
```

Expected Output

```
diff.tool=p4merge
merge.tool=p4merge
```
