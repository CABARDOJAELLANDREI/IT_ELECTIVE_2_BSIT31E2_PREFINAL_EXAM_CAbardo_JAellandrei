<div align="center">

  <!-- Top Hero Banner Panel with Theme Gradient -->
  <svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 1200 300" width="100%" style="border-radius: 12px; margin-bottom: 20px;">
    <defs>
      <linearGradient id="cyberGradient" x1="0%" y1="0%" x2="100%" y2="100%">
        <stop offset="0%" stop-color="#07192f" />
        <stop offset="45%" stop-color="#0c2840" />
        <stop offset="100%" stop-color="#2a0826" />
      </linearGradient>
      <linearGradient id="badgeGrad" x1="0%" y1="0%" x2="100%" y2="0%">
        <stop offset="0%" stop-color="#00d2ff" />
        <stop offset="100%" stop-color="#9d4edd" />
      </linearGradient>
    </defs>
    
    <!-- Background Panel -->
    <rect width="1200" height="300" rx="16" fill="url(#cyberGradient)" />
    
    <!-- Top Glowing Accent Line -->
    <rect y="0" width="1200" height="6" fill="url(#badgeGrad)" />
    
    <!-- Header Content -->
    <rect x="490" y="45" width="220" height="32" rx="16" fill="url(#badgeGrad)" />
    <text x="600" y="66" fill="#ffffff" font-family="'Plus Jakarta Sans', Arial, sans-serif" font-size="14" font-weight="bold" text-anchor="middle" letter-spacing="2">IT ELECTIVE 2</text>
    
    <text x="600" y="135" fill="#ffffff" font-family="'Plus Jakarta Sans', Arial, sans-serif" font-size="38" font-weight="800" text-anchor="middle">Prefinal Exam Portal Dashboard</text>
    
    <text x="600" y="180" fill="#00d2ff" font-family="'Plus Jakarta Sans', Arial, sans-serif" font-size="20" font-weight="600" text-anchor="middle" opacity="0.9">Web Systems &amp; Technologies — Dynamic Question Bank</text>
    
    <text x="600" y="235" fill="#e2e8f0" font-family="'Plus Jakarta Sans', Arial, sans-serif" font-size="18" font-weight="500" text-anchor="middle">
      Jaell Andrei Cabardo  •  BSIT31E2  •  A.Y. 2026–2027
    </text>
  </svg>

  <!-- GitHub Badges -->
  <p>
    <img src="https://img.shields.io/badge/IT_ELECTIVE_2-PREFINAL_EXAM-00d2ff?style=for-the-badge&logoColor=white" alt="Course Badge" />
    <img src="https://img.shields.io/badge/SECTION-BSIT31E2-9d4edd?style=for-the-badge&logoColor=white" alt="Section Badge" />
    <img src="https://img.shields.io/badge/FRAMEWORK-ASP.NET_CORE_MVC-00ff87?style=for-the-badge&logo=dotnet&logoColor=black" alt="Framework Badge" />
  </p>

</div>

## 📌 Repository Information

<table>
  <tr>
    <td><b>Repository Name</b></td>
    <td><code>IT_ELECTIVE_2_BSIT31E2_PREFINAL_EXAM_Cabardo_JaellAndrei</code></td>
  </tr>
  <tr>
    <td><b>Architecture</b></td>
    <td>ASP.NET Core MVC (In-Memory Data Storage / No DB)</td>
  </tr>
  <tr>
    <td><b>Design Theme</b></td>
    <td>Dark Cyber Glassmorphism (Neon Accents & Frosted Panels)</td>
  </tr>
  <tr>
    <td><b>Total Commits</b></td>
    <td>25+ Sequential Progress Commits</td>
  </tr>
</table>

---

## 🚀 Key Features

* <b>💎 Cyber-Glassmorphism Interface:</b> Deep navy gradient background paired with translucent blurred cards and glowing status indicators.
* <b>⚡ In-Memory Architecture:</b> Built with strongly typed C# models and static dataset collections—no external SQL database needed.
* <b>🔍 Interactive Search & Navigation:</b> Instant client-side search bar and quick-jump navigation pills to filter all 20 examination items.
* <b>💡 Question Rationale & Indicators:</b> Clear visual feedback with neon-green badges for correct answers and highlighted explanations.

---

## 🎯 Learning Objectives Coverage

| Objective | Status | Implementation Details |
| :--- | :---: | :--- |
| **1. Repository Naming Format** | 🛠️ Completed | Structured using standard exam guidelines. |
| **2. MVC Application Build** | 🛠️ Completed | Implemented Models, Views, and Controllers displaying all 20 exam items. |
| **3. Project README Setup** | 🛠️ Completed | Styled HTML documentation detailing project specifications. |
| **4. Student Identification** | 🛠️ Completed | Displayed student name and section in UI header and README header. |
| **5. Commit History Tracking** | 🛠️ Completed | Minimum of 20 commits logged (1 commit per answered item). |

---

## 📁 Folder Structure

```text
📂 Cabardo_Exam
 ┣ 📂 Controllers
 ┃ ┗ 📜 ExamController.cs         <-- Exam dataset & action routes
 ┣ 📂 Models
 ┃ ┗ 📜 ExamQuestion.cs           <-- Question entity schema
 ┣ 📂 Views
 ┃ ┣ 📂 Exam
 ┃ ┃ ┗ 📜 Index.cshtml            <-- Cyber-Glassmorphism UI dashboard
 ┃ ┗ 📂 Shared
 ┃   ┗ 📜 _Layout.cshtml          <-- Core layout with fonts & icons
 ┣ 📂 wwwroot                     <-- Bootstrap & site styling assets
 ┗ 📜 README.md                   <-- HTML-styled documentation
