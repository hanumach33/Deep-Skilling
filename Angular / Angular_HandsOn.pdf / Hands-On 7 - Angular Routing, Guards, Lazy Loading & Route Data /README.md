# Hands-On 7 - Angular Routing, Guards, Lazy Loading & Route Data

## Objective

Learn Angular Routing, Route Parameters, Query Parameters, Nested Routes, Lazy Loading, and Route Guards.

---

## Topics Covered

- Angular Routing
- Route Parameters
- Query Parameters
- Nested Routes
- Lazy Loading
- CanActivate Guard
- CanDeactivate Guard
- Router Navigation

---

## Generate Components

```bash
ng generate component pages/course-detail

ng generate component pages/not-found

ng generate component layouts/courses-layout
```

---

## Generate Guards

```bash
ng generate guard guards/auth

ng generate guard guards/unsaved-changes
```

---

## Generate Module

```bash
ng generate module features/enrollment --routing
```

---

## Files

- app.routes.ts
- course-detail.component.ts
- course-list.component.ts
- auth.guard.ts
- unsaved-changes.guard.ts
- auth.service.ts
- courses-layout.component.html
