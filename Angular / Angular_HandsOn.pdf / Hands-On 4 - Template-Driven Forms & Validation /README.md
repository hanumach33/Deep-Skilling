# Hands-On 4 - Template-Driven Forms & Validation

## Objective

Build a Student Enrollment Request Form using Angular Template-Driven Forms with built-in validation and contextual error messages.

---

## Topics Covered

- FormsModule
- ngForm
- ngModel
- Template-Driven Forms
- Validation
- ng-valid / ng-invalid
- ng-touched
- Reset Form

---

## Generate Component

```bash
ng generate component pages/enrollment-form
```

---

## Add Route

```typescript
{
    path: 'enroll',
    component: EnrollmentFormComponent
}
```

---

## Import

```typescript
import { FormsModule } from '@angular/forms';
```

---

## Files

- enrollment-form.component.ts
- enrollment-form.component.html
- enrollment-form.component.css
