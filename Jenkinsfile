pipeline {
  agent any
  stages {
    stage('Mensagem') {
      steps {
        echo 'Gerando emails para notificação'
        mail(subject: '[Jenkins] Pipeline - BodyOn', body: 'Pipeline foi iniciado, este Ã© um email de verificaÃ§Ã£o.', to: 'ewaldoj18@gmail.com, marianaoliveirafernandes11@gmail.com, jejosu346@gmail.com')
        echo 'Emails enviados'
      }
    }

  }
}