// UbuntuCRM – Site JavaScript

// ── Sticky header effect
window.addEventListener('scroll', () => {
    const header = document.getElementById('siteHeader');
    if (header) {
        header.style.boxShadow = window.scrollY > 20 ? '0 4px 32px rgba(0,0,0,0.4)' : 'none';
    }
});

// ── Animate-in elements on scroll
const observerCallback = (entries) => {
    entries.forEach(entry => {
        if (entry.isIntersecting) {
            entry.target.style.opacity = '1';
            entry.target.style.transform = 'translateY(0)';
        }
    });
};

const observer = new IntersectionObserver(observerCallback, { threshold: 0.1 });

document.querySelectorAll('.animate-in').forEach(el => {
    el.style.opacity = '0';
    el.style.transform = 'translateY(20px)';
    el.style.transition = '0.6s ease';
    observer.observe(el);
});

// ── CRM Sidebar mobile toggle
document.addEventListener('DOMContentLoaded', () => {
    const toggle = document.getElementById('sidebarToggle');
    const sidebar = document.querySelector('.crm-sidebar');
    if (toggle && sidebar) {
        toggle.addEventListener('click', () => {
            sidebar.classList.toggle('mobile-open');
        });
    }
});

// ── Sector card click
document.querySelectorAll('.sector-card').forEach(card => {
    card.addEventListener('click', () => {
        document.querySelectorAll('.sector-card').forEach(c => c.style.borderColor = '');
        card.style.borderColor = 'var(--sa-gold)';
    });
});

// ── Number counter animation for hero stats
function animateCounter(el, target, prefix = '', suffix = '') {
    let current = 0;
    const increment = target / 60;
    const timer = setInterval(() => {
        current += increment;
        if (current >= target) {
            current = target;
            clearInterval(timer);
        }
        el.textContent = prefix + Math.floor(current).toLocaleString('en-ZA') + suffix;
    }, 16);
}

